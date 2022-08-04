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

        private const int pyuosize = 30;
        private const int frame = 10;
        private const int optframe = 50;

        bool isWorking = false;
        int score = 0;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            int mapSizeX = pyuosize * Pyuo.mapSizeX + 2 * frame;
            int mapSizeY = pyuosize * Pyuo.mapSizeY + 2 * frame + optframe;

            // 폼 사이즈
            this.Text = "Custom Pyuo v1.0";
            this.ClientSize = new Size(mapSizeX, mapSizeY);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            g = this.CreateGraphics();

            this.BackColor = Color.Gray;

            Pyuo.map[0, 14] = 1;
            Pyuo.map[1, 14] = 1;
            Pyuo.map[2, 14] = 1;
            Pyuo.map[1, 13] = 2;
            Pyuo.map[2, 13] = 2;
            Pyuo.map[3, 14] = 2;
            Pyuo.map[1, 12] = 1;
            Pyuo.map[3, 8] = 2;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.DrawLine();
            this.DrawPyuo();
        }

        public void DrawLine()
        {
            for (int x = 0; x <= Pyuo.mapSizeX; x++)
            {
                this.g.DrawLine(pen, 
                                new Point(frame + x * pyuosize, frame + optframe), 
                                new Point(frame + x * pyuosize, frame + optframe + Pyuo.mapSizeY * pyuosize)
                                );
            }
            for (int y = 0; y <= Pyuo.mapSizeY; y++)
            {
                this.g.DrawLine(pen,
                                new Point(frame, frame + optframe + pyuosize * y),
                                new Point(frame + pyuosize * Pyuo.mapSizeX, frame + optframe + pyuosize * y)
                                );
            }
        }

        public void FillPyuo(byte num, int X, int Y)
        {
            if (num != 0)
            {
                Rectangle rect = new Rectangle(X, Y, pyuosize - 1, pyuosize - 1);
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

        public void DrawPyuo()
        {
            for (int posX = 0; posX < Pyuo.mapSizeX; posX++)
            {
                for (int posY = 0; posY < Pyuo.mapSizeY; posY++)
                {
                    int X = posX * pyuosize + frame;
                    int Y = posY * pyuosize + frame + optframe;

                    FillPyuo(Pyuo.map[posX, posY], X, Y);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 뿌요 내리는거
            Pyuo.OrderPyuo(Pyuo.map);

            // 이전 맵과 같은가?
            if (Pyuo.ChkMaps())
            {
                Pyuo.cmap = Pyuo.map.Clone() as byte[,];

                for (int i = 0; i < Pyuo.mapSizeX; i++)
                {
                    for (int j = 0; j < Pyuo.mapSizeY; j++)
                    {
                        Pyuo.chkPyuo(i, j);
                    }
                }
            }

            Pyuo.bmap = Pyuo.map.Clone() as byte[,];
            this.Invalidate();
            
        }

    }
}