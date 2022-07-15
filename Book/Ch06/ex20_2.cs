using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 6-20_1
 * 
 * Private 생성자
 */

namespace Book.Ch06
{
    internal class ex20_2
    {
        class Sample
        {
            public static int value;
            
            static Sample()
            {
                value = 10;
                Console.WriteLine("정적 생성자 호출");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("두 번째 위치");

            Console.WriteLine(Sample.value);
            Console.WriteLine("세 번째 위치");
        }
    }
}