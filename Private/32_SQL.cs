using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
/*
날짜 : 2023. 7. 16
이름 : 배성훈
내용 : SQL
    31에서만든 데이터베이스에 정보 가져오기

    만약 없는 경우 어떻게 반응하는지도 확인
*/

namespace Private
{
    internal class _32_SQL
    {

        static void Main32(string[] args)
        {

            DB db = new DB(3306, "root", "2580", "userdb");

            db.Connect();
            // db.RegisterInfo("127.0.0.2", "없음");
            db.ChkAccount("127.0.0.2");
        }

        public class DB
        {

            private string server = "127.0.0.1";
            private string port;
            private string username;
            private string password;
            private string database;

            MySqlConnection conn;

            public DB(int port, string username, string password, string database)
            {

                this.port = port.ToString();
                this.username = username;
                this.password = password;
                this.database = database;

                string strConn = $"server={this.server};port={this.port};username={this.username};password={this.password};database={this.database}";

                conn = new MySqlConnection(strConn);
            }

            public void Connect()
            {

                try
                {

                    conn.Open();
                    Console.WriteLine("데이터 베이스 접속 완료");
                }
                catch (Exception e)
                {

                    Console.WriteLine($"접속 실패 {e.Message}");
                }
            }

            public void ChkAccount(string ip)
            {

                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = $"SELECT `name` FROM `user` WHERE `ip` = '{ip}';";
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {


                        if (reader.Read())
                        {

                            Console.WriteLine(reader.GetString(0));
                        }
                        else
                        {

                            Console.WriteLine("해당 유저의 정보가 존재하지 않습니다.");
                        }
                    }
                }
            }

            public void RegisterInfo(string ip, string name)
            {

                using (MySqlCommand cmd = conn.CreateCommand())
                { 
                    
                    cmd.CommandText = $"INSERT INTO `user` VALUES ('{name}', '{ip}');";
                    cmd.ExecuteNonQuery();
                }
            }


            ~DB()
            {

                conn.Close();
            }
        }
    }
}

// https://ckbcorp.tistory.com/1284
// 마리아db 버전이 높아서 생기는 버그