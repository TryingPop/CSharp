using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 5-2
 * 
 * Random 클래스를 사용한 임의의 실수 생성
 */

namespace Book.Ch05
{
    internal class ex02
    {
        static void Main2(string[] args)
        {
            Random random = new Random();

            // 0 과 1사이의 임의의 난수 생성
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
        }
    }
}
