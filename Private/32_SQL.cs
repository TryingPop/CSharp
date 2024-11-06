using System;
using System.Collections.Generic;
using System.Data;
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
            db.RegisterInfo("127.0.0.3", "호호");

            // db.RenameAccount("127.0.0.2", "하하");
        }

        public class DB
        {

            private string server = "127.0.0.1";
            private string port;
            private string username;
            private string password;
            private string database;

            MySqlConnection conn;
            MySqlCommand cmd;
            public DB(int port, string username, string password, string database)
            {

                this.port = port.ToString();
                this.username = username;
                this.password = password;
                this.database = database;

                string strConn = $"server={this.server};port={this.port};username={this.username};password={this.password};database={this.database}";

                conn = new MySqlConnection(strConn);
            }

            /// <summary>
            /// 해당 데이터베이스에 접속
            /// </summary>
            public void Connect()
            {

                try
                {

                    conn.Open();

                    cmd = conn.CreateCommand();
                    Console.WriteLine("데이터 베이스 접속 완료");
                }
                catch (Exception e)
                {

                    try
                    {

                        cmd.Dispose();
                    }
                    catch { }

                    try
                    {
                        conn.Close();
                    }
                    catch { }

                    Console.WriteLine($"접속 실패 {e.Message}");
                }
            }

            /// <summary>
            /// 해당 ip가 이전에 접속한 기록이 있는지 검색한다
            /// </summary>
            /// <param name="ip">검사할 ip</param>
            /// <returns>기존 name 반환 없으면 string.Empty</returns>
            private string ChkAccount(string ip)
            {

                try
                {

                    // 여기 name, ban 순서로 담는다!
                    cmd.CommandText = $"SELECT `name`, `ban` FROM `info` WHERE `ip` = '{ip}';";
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {


                        if (reader.Read())
                        {

                            // 각각 같은 표현!
                            // Console.WriteLine(reader.GetString(0));
                            // Console.WriteLine(reader["name"].ToString());

                            // Console.WriteLine(reader["ban"]);
                            // Console.WriteLine(reader[1].ToString());

                            if (reader["ban"].ToString() == "Y")        // Y는 접속이 제한된 계정
                            {
                        
                                return null;
                            }

                            return reader.GetString(0);
                        }
                        else
                        {

                            Console.WriteLine("계정이 존재하지 않습니다.");
                        }
                    }
                }
                catch
                {

                    Console.WriteLine("계정 확인 실패");
                }

                return string.Empty;
            }

            /// <summary>
            /// 계정 등록
            /// </summary>
            /// <param name="ip"></param>
            /// <param name="name"></param>
            /// <returns></returns>
            public string RegisterInfo(string ip, string name)
            {

                string chk = ChkAccount(ip);
                try
                {

                    if (chk == null)
                    {

                        Console.WriteLine($"{ip}");
                        Console.WriteLine("접속이 제한된 ip입니다.");
                        return null;
                    }

                    if (chk == string.Empty)
                    {

                        Console.WriteLine("계정을 등록합니다.");
                        cmd.CommandText = $"INSERT INTO `info` VALUES ('{name}', '{ip}', 'N');";
                        cmd.ExecuteNonQuery();
                    }
                }
                catch
                {

                    Console.WriteLine("계정 등록 실패");
                }

                return chk;
            }

            public void RenameAccount(string ip, string name)
            {

                try
                {

                    cmd.CommandText = $"UPDATE `info` SET `name` = '{name}' WHERE `ip` = '{ip}';";
                    cmd.ExecuteNonQuery();
                }
                catch
                {

                    Console.WriteLine("이름 변경 실패");
                }
            }
            ~DB()
            {

                cmd.Dispose();
                conn.Close();
            }
        }
    }
}

// https://ckbcorp.tistory.com/1284
// 마리아db 버전이 높아서 생기는 버그