using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 파일 입출력 실습하기
 * 
 * 파일 입출력(I/O)
 *  - 파일은 컴퓨터 저장매체(HDD)에 저장되는 데이터 묶음
 *  - 프로그램은 데이터 처리(Process)와 더불어 처리 결과를 저장하기 위해 파일 입출력 수행
 */

namespace Ch08
{
    // python의 f = open()과 비슷?
    internal class _3_파일_입출력
    {
        static void Main3(string[] args)
        {
            // 파일 읽기 (Read)
            string path1 = "C:\\Users\\502\\Desktop\\CSStudy\\Ch08\\Sub1\\Sample1.txt";


            // 파일 스트림 생성 및 연결
            // 파일을 읽어드리는 스트림
            // 파일이 없으면 에러가 뜨기에 반드시 에러작업이 필요하다
            /*
            try
            {
                FileStream fs = new FileStream(path1, FileMode.Open, FileAccess.Read);

                // 텍스트 파일 전용 보조 스트림
                StreamReader sr = new StreamReader(fs);

                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

                sr.Close();
                fs.Close();
            }
            catch 
            {
                Console.WriteLine("경로상에 파일이 존재하지 않습니다.");
            }
            */
            // 참조변수는 null로 초기화 해줘야한다

            FileStream fs = null;

            // 바이너리 파일은
            // BinaryReader 클래스 이용하면 된다.
            StreamReader sr = null;
            try
            {
                fs = new FileStream(path1, FileMode.Open, FileAccess.Read);

                // 텍스트 파일 전용 보조 스트림
                sr = new StreamReader(fs);

                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                fs.Close();
                sr.Close();

            }
            catch
            {
                Console.WriteLine("경로상에 파일이 존재하지 않습니다.");
            }
            finally
            {
                // null참조타입은 대상(메서드)으로 향할 수 없다고 오류뜬다
                // sr.Close();
                // fs.Close();
            }


            // 파일 쓰기 (Write)
            string path2 = "C:\\Users\\502\\Desktop\\CSStudy\\Ch08\\Sub1\\Sample2.txt";

            FileStream fs2 = null;
            StreamWriter sw = null;

            try
            {
                fs2 = new FileStream(path2, FileMode.OpenOrCreate, FileAccess.Write);
                // StreamWriter 
                // args에 append : true 라고 입력하면
                // 이어붙이기 가능
                sw = new StreamWriter(fs2);

                sw.WriteLine("Welcom World!");
                sw.WriteLine("Welcom Korea!");
                sw.WriteLine("Welcom Busan");

                sw.Close();
                fs2.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }

            // 파일 읽고 쓰기
            string file1 = "C:\\Users\\502\\Desktop\\CSStudy\\Ch08\\Sub1\\Sample1.txt";
            string file2 = "C:\\Users\\502\\Desktop\\CSStudy\\Ch08\\Sub1\\Sample2.txt";

            try
            {
                // using 선언으로 스트림 자원해제 자동 실행
                // Access 는 생략가능 StreamReader, Writer이므로
                // using은 python with 구문과 같다 즉, 끝나면 자동으로 close
                // 앞에서 file1의 경로 파일이 닫히지 않으면 이미 연결되어져 있다고 새로 열 수 없다
                // Write 덮어쓰기
                using (StreamReader reader = new StreamReader(new FileStream(file1, FileMode.Open)))
                {
                    using (StreamWriter writer = new StreamWriter(new FileStream(file2, FileMode.Open)))
                    {
                        string txt;
                        while ((txt = reader.ReadLine()) != null)
                        {
                            writer.WriteLine(txt);
                        }
                    }
                }
                

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
