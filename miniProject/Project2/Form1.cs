using MySql.Data.MySqlClient;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 추후에 테이블 목록을 스크롤 바로 받아오는 걸로 바꾸기
        // 현재껀 조회 버튼 누르면 실행되는걸로 하기!
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = DBAccess.Instance.SelectUsers();
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // 입력 데이터 저장
            string uid = txtUid.Text;
            string name = txtName.Text;
            string hp = txtHp.Text;
            string age = nAge.Text;

            DBAccess.Instance.InsertUser(uid, name, hp, age);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = DBAccess.Instance.SelectUsers();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUid.Text = "";
            txtName.Text = "";
            txtHp.Text = "";
            nAge.Value = 0;
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            // Console.WriteLine(row);
            DataGridViewRow dataRow = dataGrid.Rows[row];

            txtUid.Text = dataRow.Cells[0].Value.ToString();
            txtName.Text = dataRow.Cells[1].Value.ToString();
            txtHp.Text = dataRow.Cells[2].Value.ToString();
            nAge.Text = dataRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;
            string name = txtName.Text;
            string hp = txtHp.Text;
            string age = nAge.Text;
            DBAccess.Instance.UpdateUser(uid, name, hp, age);
            MessageBox.Show("데이터가 수정되었습니다.", "확인");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;
            DialogResult result = MessageBox.Show("데이터를 삭제하시겠습니까?.", "확인", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DBAccess.Instance.DeleteUser(uid);
                MessageBox.Show("데이터가 삭제되었습니다.", "확인");
            }

        }
    }
}