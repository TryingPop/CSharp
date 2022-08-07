using static SimpleProject1.Game;

namespace SimpleProject1
{
    public partial class Form1 : Form
    {
        Graphics g;
        Brush redBrush = new SolidBrush(Color.Red);
        Brush yellowBrush = new SolidBrush(Color.Yellow);
        Brush greenBrush = new SolidBrush(Color.Green);
        Brush blueBrush = new SolidBrush(Color.Blue);
        Brush purpleBrush = new SolidBrush(Color.Purple);

        Pen pen = new Pen(Color.Black);

        private const int dolsize = 30;
        private const int frame = 10;
        private const int optframe = 50;
        bool userTurn = false;
        int score = 0;
        byte speed = 1;
        bool spacebar = true;
        Random rand = new Random();
        // private Rectangle imgrect = new Rectangle();


        public Form1()
        {
            InitializeComponent();

            int sizeX = dolsize * mapSizeX + 2 * frame;
            int sizeY = dolsize * mapSizeY + 2 * frame + optframe;

            // 폼 사이즈
            this.Text = "Custom Dol v1.0";
            this.ClientSize = new Size(sizeX, sizeY);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            g = this.CreateGraphics();
            
            this.BackColor = Color.Gray;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.DrawLine();
            this.DrawMap();
            if (userTurn)
            {
                this.DrawDols();
            }
        }

        // 판 그리기
        public void DrawLine()
        {
            for (int x = 0; x <= mapSizeX; x++)
            {
                this.g.DrawLine(pen, 
                                new Point(frame + x * dolsize, frame + optframe), 
                                new Point(frame + x * dolsize, frame + optframe + mapSizeY * dolsize)
                                );
            }
            for (int y = 0; y <= mapSizeY; y++)
            {
                this.g.DrawLine(pen,
                                new Point(frame, frame + optframe + dolsize * y),
                                new Point(frame + dolsize * mapSizeX, frame + optframe + dolsize * y)
                                );
            }
        }

        // 색상에 맞는 돌 배치
        // color, 좌표
        public void FillDol(int num, int X, int Y)
        {
            if (num != 0)
            {
                Rectangle rect = new Rectangle(X, Y, dolsize - 1, dolsize - 1);
                this.g.DrawEllipse(pen, rect);

                Brush b;

                if (num == 1)
                {
                    b = redBrush;
                }
                else if (num == 2)
                {
                    b = yellowBrush;
                }
                else if (num == 3)
                {
                    b = greenBrush;
                }
                else if (num == 4)
                {
                    b = blueBrush;
                }
                else
                {
                    b = purpleBrush;
                }

                this.g.FillEllipse(b, rect);
            }
        }

        // 맵의 인덱스를 좌표로 바꿔주는 메서드
        public void SetPos(int x, int y, out int X, out int Y)
        {
            X = x * dolsize + frame;
            Y = (y - 1) * dolsize + frame + optframe; 
        }

        // 돌 그리기
        public void DrawDols()
        {
            int X;
            int Y;
            for (int i = 0; i < 2; i++)
            {
                // X = (Dols[i].x * dolsize + frame);
                // Y = ((Dols[i].y - 1) * dolsize + frame + optframe );
                SetPos(Dols[i].x, Dols[i].y, out X, out Y);
                if (Dols[i].y >=1)
                {
                    FillDol(Dols[i].color, X, Y);
                }
            }
        }

        // 맵의 돌 배치
        public void DrawMap()
        {
            for (int posX = 0; posX < mapSizeX; posX++)
            {
                for (int posY = mapSizeY; posY > 0; posY--)
                {
                    int X;
                    int Y;
                    SetPos(posX, posY, out X, out Y);
                    FillDol(map[posX, posY], X, Y);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (userTurn)
            {
                Dols[0].y += 1;
                Dols[1].y += 1;
                userTurn = AddDols();
                
                // 특정부분만 화면 교체
                // int X;
                // int Y;
                // SetPos(Dols[0].x - 1, Dols[0].y - 2, out X, out Y);
                // imgrect = new Rectangle(X, Y, 3 * dolsize, 3 * dolsize);
                // this.Invalidate(imgrect);
            }
            else
            {
                // 돌 정렬 및 돌이 다 내려왔는지 판별
                // 이후 돌이 다 내려온 경우 4개 이상 모인돌 판별
                // 게임 오버 판별
                // 게임 오버가 아닐 시 유저턴시작
                if (OrderDol())
                {
                    for (int i = 0; i < mapSizeX; i++)
                    {
                        for (int j = 0; j < mapSizeY; j++)
                        {
                            ChkLink(i, j);
                        }
                    }


                    if (ChkMaps())
                    {
                        if (Dols != null)
                        {
                            if (GameOver())
                            {
                                timer1.Stop();
                                var result = MessageBox.Show("게임 오버", "Game Over", MessageBoxButtons.YesNo);
                                
                                if (result == DialogResult.Yes)
                                {
                                    map = new int[mapSizeX, mapSizeY + 1];
                                    timer1.Start();
                                }
                            }
                        }
                        GenerateDols();
                        userTurn = true;
                    }
                }
                
            }
            this.Invalidate();
        }

        // 화면 깜짝임 장지 코드
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (userTurn)
            {
                int num1; int num2;
                if (e.KeyCode == Keys.Left)
                {
                    num1 = Dols[0].x - 1;
                    num2 = Dols[1].x - 1;

                    if (!ChkCollision(num1, Dols[0].y) && !(ChkCollision(num2, Dols[1].y)))
                    {
                        Dols[0].x = num1;
                        Dols[1].x = num2;
                    }
                }
                if (e.KeyCode == Keys.Right)
                {
                    num1 = Dols[0].x + 1;
                    num2 = Dols[1].x + 1;
                    if (!ChkCollision(num1, Dols[0].y) && !(ChkCollision(num2, Dols[1].y)))
                    {
                        Dols[0].x = num1;
                        Dols[1].x = num2;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    turnCount++;
                }
                
                if (e.KeyCode == Keys.Space && spacebar)
                {
                    RotationDols();
                }
            }
        }
    }
}

// 참고 사이트
// https://easy-coding.tistory.com/70
