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
        bool drawturn = false;
        bool keyinput = false;
        bool userTurn = false;
        int score = 0;
        byte speed = 1;
        bool spacebar = true;
        Random rand = new Random();

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
            
            bmap[0, 15] = -1;
            map[0, 15] = 1;
            map[1, 15] = 1;
            map[2, 15] = 1;
            map[1, 14] = 2;
            map[2, 14] = 2;
            map[3, 15] = 2;
            map[1, 13] = 1;
            map[3, 9] = 2;
            map[0, 14] = 3;
            map[0, 13] = 3;
            map[1, 12] = 3;
            map[2, 13] = 3;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.DrawLine();
            this.DrawMap();
            if (userTurn)
            {
                this.DrawDols();
            }
            spacebar = true;
        }

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

        public void DrawDols()
        {
            for (int i = 0; i < 2; i++)
            {
                int X = (Dols[i].x * dolsize + frame);
                int Y = ((Dols[i].y - 1) * dolsize + frame + optframe );
                if (Dols[i].y >=1)
                {
                    FillDol(Dols[i].color, X, Y);
                }
            }
        }

        public void DrawMap()
        {
            for (int posX = 0; posX < mapSizeX; posX++)
            {
                for (int posY = mapSizeY; posY > 0; posY--)
                {
                    int X = (posX * dolsize + frame);
                    int Y = ((posY - 1) * dolsize + frame + optframe);

                    FillDol(map[posX, posY], X, Y);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (userTurn)
            {
                drawturn = turnChk(speed);
                if (drawturn)
                {
                    Dols[0].y += 1;
                    Dols[1].y += 1;
                }
                userTurn = AddDols();
            }
            else
            {
                drawturn = turnChk(5);

                // 돌 내리는거
                if (drawturn)
                {
                    OrderDol();

                    // 이전 맵과 같은가?
                    if (ChkMaps())
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
                            GenerateDols();
                            userTurn = true;
                        }
                    }
                }
            }
            if (drawturn || keyinput)
            {
                this.Invalidate();
                keyinput = false;
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

                    if (SafeIdx(num1, 0) && SafeIdx(num2, 0))
                    {
                        Dols[0].x = num1;
                        Dols[1].x = num2;
                        keyinput = true;
                    }
                }
                if (e.KeyCode == Keys.Right)
                {
                    num1 = Dols[0].x + 1;
                    num2 = Dols[1].x + 1;
                    if (SafeIdx(num1, 0) && SafeIdx(num2, 0))
                    {
                        Dols[0].x = num1;
                        Dols[1].x = num2;
                        keyinput = true;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    turnCount++;
                }
                if (e.KeyCode == Keys.Space && spacebar)
                {
                    RotationDols();
                    keyinput = true;
                    spacebar = false;
                }
            }
        }
    }
}