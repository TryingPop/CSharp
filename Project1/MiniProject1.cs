namespace Project1
{
    public partial class MiniProject1 : Form
    {
        private double savedNum = 0;
        private int operate = 0; // 1: Plus, 2: Minus, 3: Multi, 4: Div 

        public MiniProject1()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            this.chkZero();
            Button btn = sender as Button;
            txtResult.Text += btn.Tag.ToString();
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            this.Operate();
            txtResult.Text = "0";
            Button btn = sender as Button;
            this.operate = int.Parse(btn.Tag.ToString());
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            this.Operate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            this.savedNum = 0;
        }


        private void Operate()
        {
            double finalNum = double.Parse(txtResult.Text);
            double result = 0;
            switch (this.operate)
            {
                case 0:
                    this.savedNum = finalNum;
                    return;

                case 1:
                    result = this.savedNum + finalNum;
                    break;

                case 2:
                    result = this.savedNum - finalNum;
                    break;

                case 3:
                    result = this.savedNum * finalNum;
                    break;

                case 4:
                    result = this.savedNum / finalNum;
                    break;
            }
            txtResult.Text = result.ToString();
            this.savedNum = result;
        }

        private void chkZero()
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "";
            }
        }
    }
}