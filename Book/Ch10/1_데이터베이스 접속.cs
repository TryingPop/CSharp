using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 데이터베이스 프로그래밍 실습하기
 */

namespace Ch10
{
    internal class _1_데이터베이스_접속
    {
        static void Main1(string[] args)
        {
            // 데이터베이스 접속 정보
            
            // ip
            string server = "127.0.0.1";
            
            // port번호
            string port = "3306";

            // 계정, 비밀번호
            string username = "root";
            string password = "1234";

            // 접속할 데이터베이스
            string database = "userdb";

            // 데이터베이스 커넥션 생성
            // 띄어쓰기 X
            string strConn = $"server={server};port={port};username={username};password={password};database={database}";
            /*
            MySqlConnection conn = new MySqlConnection(strConn);

            // 데이터베이스 접속
            try
            {
                conn.Open();
                Console.WriteLine("접속 성공!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"접속 실패 : {e.Message}");
            }
            finally
            {
                conn.Close();
                Console.WriteLine("접속 종료!");
            }*/

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                Console.WriteLine("접속 성공!");
                Console.WriteLine("접속 종료!");
            }
        }
    }
}

// 도구 > NuGet 패키지 관리자 > 솔루션용 패키지 관리 > 찾아보기에서 mysql 검색 > 맨위에 mysql 선택 > 원하는 프로젝트에 설치
// 종속성에 패키지 > mysql.Data가 추가됨을 확인할 수 있다