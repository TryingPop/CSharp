using MySql.Data.MySqlClient;

namespace Project2
{
    internal class DBAccess
    {
        private const string SERVER = "127.0.0.1";
        private const string PORT = "3306";
        private const string USERNAME = "root";
        private const string PASSWORD = "1234";
        private const string DATABASE = "userdb";
        private const string TABLE = "user3";

        // 싱글톤
        private static DBAccess instance = new DBAccess();
        public static DBAccess Instance { get => instance; }
        private DBAccess() { }

        public MySqlConnection Connect()
        {
            string strConn = $"server={SERVER};port={PORT};username={USERNAME};password={PASSWORD};database={DATABASE};";
            MySqlConnection conn = new MySqlConnection(strConn);
            return conn;
        }

        // 
        // CRUD - DB에서 기본 메서드를 모아놓은거
        public void InsertUser(string uid, string name, string hp, string age) 
        {
            // DB 접속 커넥션 생성
            try
            {
                using (MySqlConnection conn = this.Connect())
                {
                    // DB 접속
                    conn.Open();

                    // SQL 실행
                    MySqlCommand cmd = conn.CreateCommand();
                    // 보간 처리
                    cmd.CommandText = $"INSERT INTO `{TABLE}` VALUES ('{uid}', '{name}', '{hp}', {age})";

                    // 결과 처리
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            MessageBox.Show("데이터가 추가되었습니다.", "확인");
        }
        public void SelectUser() { }
        public List<User> SelectUsers() 
        {
            List<User> userList = new List<User>();
            
            try
            {
                using (MySqlConnection conn = this.Connect())
                {
                    // DB 접속
                    conn.Open();

                    // SQL 실행
                    MySqlCommand cmd = conn.CreateCommand();
                    // 보간 처리
                    cmd.CommandText = $"SELECT * FROM `{TABLE}`";

                    // 결과 처리
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        User user = new User(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), int.Parse(reader[3].ToString()));

                        userList.Add(user);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return userList;
        }
        public void UpdateUser(string uid, string name, string hp, string age) 
        {
            try
            {
                using (MySqlConnection conn = this.Connect())
                {
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = $"UPDATE `{TABLE}` SET `name` = '{name}', `hp` = '{hp}', `age` = {age} WHERE `uid` = '{uid}'";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        public void DeleteUser(string uid) 
        {
            try
            {
                using (MySqlConnection conn = this.Connect())
                {
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = $"DELETE FROM `{TABLE}` WHERE `uid` = '{uid}'";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
