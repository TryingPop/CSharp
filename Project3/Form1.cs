

namespace Project3
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Pen pen;
        private Brush wBrush, bBrush;

        private const int margin = 40;
        private const int sizeNun = 30;
        private const int sizeDol = 28;

        private bool isWhite = false;
        private bool isWin = false;
        // enum STONE { none, black, white };
        // STONE[,] dataSet = new STONE[19, 19];

        private Omok omok = new Omok();

        public Form1()
        {
            InitializeComponent();

            // 그래픽 객체 초기화
            this.g = this.CreateGraphics();
            this.pen = new Pen(Color.Black);
            this.wBrush = new SolidBrush(Color.White);
            this.bBrush = new SolidBrush(Color.Black);

            // 바둑판 색, 크기 조절
            this.BackColor = Color.DarkOrange;
            this.ClientSize = new Size(2 * margin + 18 * sizeNun, 2 * margin + 18 * sizeNun);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        // 오목 main?
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.X - margin + sizeNun / 2) / sizeNun;
            int y = (e.Y - margin + sizeNun / 2) / sizeNun;

            Omok.chkidx(x, y);
            // Console.WriteLine($"x : {x}, y : {y}");

            // 돌이 놓여있는지 확인
            if (Omok.dataSet[x, y] != Omok.STONE.none)
            {
                MessageBox.Show("이미 돌이 놓여있습니다.");
                return;
            }

            // 검은돌, 흰돌 그리기
            Rectangle dol = new Rectangle(Form1.margin + (Form1.sizeNun * x) - (Form1.sizeNun / 2), 
                                          Form1.margin + (Form1.sizeNun * y) - (Form1.sizeNun / 2), 
                                          Form1.sizeNun, Form1.sizeNun);
            
            if (isWhite)
            {
                g.FillEllipse(wBrush, dol);
                Omok.dataSet[x, y] = Omok.STONE.white;
            }
            else
            { 
                g.FillEllipse(bBrush, dol); 
                Omok.dataSet[x, y] = Omok.STONE.black;
            }

            // 오목 판정
            this.isWin = Omok.chkNum(x, y, 5);
            
            if (this.isWin)
            {
                DialogResult result = MessageBox.Show("오목입니다! 새로운 게임을 시작할까요?", "승리", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Action NewGame = new Action(() =>
                    {
                        this.Invalidate();
                        for (int i = 0; i < 19; i++)
                        {
                            for (int j = 0; j < 19; j++)
                            {
                                Omok.Set_dataSet();
                            }
                        }
                    });
                    NewGame();
                    return;
                }
                else
                {
                    this.Close();
                }
            }

            // 색상 변경
            this.isWhite = (this.isWhite == true? false:true);
        }

        // 화면을 줄이고 늘리면 계속 update한다
        protected override void OnPaint(PaintEventArgs e)
        {
            Console.WriteLine("On Paint!");
            for (int i = 0; i < 19; i++)
            {
                this.g.DrawLine(pen, new Point(Form1.margin, Form1.margin + (i * Form1.sizeNun)), new Point(Form1.margin + (18 * Form1.sizeNun), Form1.margin + (i * Form1.sizeNun)));
                this.g.DrawLine(pen, new Point(Form1.margin + (i * Form1.sizeNun), Form1.margin), new Point(Form1.margin + (i * Form1.sizeNun), Form1.margin + (18 * Form1.sizeNun)));
            }
        }
    }
}