using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : Select 프로그래밍 실습하기
 */

namespace Ch10
{
    internal class _5_Select_실습
    {
        static void Main5(string[] args)
        {
            // 데이터베이스 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "1234";
            string database = "userdb";

            // 데이터베이스 커넥션 생성
            string strConn = $"server={server};port={port};username={username};password={password};database={database}";
            MySqlConnection conn = new MySqlConnection(strConn);
            
            try
            {
                // 데이터베이스 접속
                conn.Open();

                // SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                // 데이터 5개 이상을 가져올려고 user2를 선택
                cmd.CommandText = "SELECT * FROM `user2`";
                
                // 명령어에 맞춰 생성된 테이블
                MySqlDataReader reader = cmd.ExecuteReader();

                // 결과 출력
                // reader.Read() << 레코드


                // reader.GetName으로 열 이름을 따온다
                Console.WriteLine($"{reader.GetName(0)}, {reader.GetName(1)}, {reader.GetName(2)}, {reader.GetName(3)}");

                while(reader.Read())
                {
                    Console.WriteLine($"uid : {reader[0]}, name : {reader[1]}, hp : {reader[2]}, age : {reader[3]}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"접속 실패 : {e.Message}");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
