using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 9-22
 * 
 * StreamReader 클래스로 파일 한 줄씩 읽기
 */

namespace Book.Ch09
{
    internal class ex22
    {
        static void Main22(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"C:test\test.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
