using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : Delete 프로그래밍 실습하기
 */

namespace Ch10
{
    internal class _4_Delete_실습
    {
        static void Main4(string[] args)
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
                cmd.CommandText = "DELETE FROM `user1` WHERE `uid` = 'c101'";
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

        }
    }
}
