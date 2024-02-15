using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : Insert 프로그래밍 실습하기
 */

namespace Ch10
{
    internal class _2_Insert_실습
    {
        static void Main2(string[] args)
        {
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "1234";
            string database = "userdb";
            string strConn = $"server={server};port={port};username={username};password={password};database={database}";

            MySqlConnection conn = new MySqlConnection(strConn);
            try
            {
                conn.Open();
                Console.WriteLine("접속 성공!");

                // SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                // 명령어 입력
                cmd.CommandText = "INSERT INTO `user1` VALUES ('c101', '김유신', '010-1234-1001', 27)";
                // 실행코드
                cmd.ExecuteNonQuery();

                Console.WriteLine("SQL 완료...");
            }
            catch (Exception e)
            {
                Console.WriteLine($"접속 실패 : {e.Message}");
            }
            finally
            {
                conn.Close();
                Console.WriteLine("접속 종료!");
            }

            // 알아서 Close 메서드 실행해준다
            // 반면 Open은 직접 해야한다!
            // 안해주면 접속불가 에러 뜬다
            using (MySqlConnection conn2 = new MySqlConnection(strConn))
            {
                conn2.Open();
                MySqlCommand cmd2 = conn2.CreateCommand();
                cmd2.CommandText = "INSERT INTO `user1` VALUES ('c101', '김유신', '010-1234-2222', 29)";
                cmd2.ExecuteNonQuery();
            }
        }
    }
}
