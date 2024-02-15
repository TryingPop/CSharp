using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 9-21
 * 
 * using 구문에서 StreamReader 클래스의 인스턴스 생성
 */

namespace Book.Ch09
{
    internal class ex21
    {
        static void Main21(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"C:test\test.txt"))
            {
                // 한 줄 읽으라는 메서드
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}
