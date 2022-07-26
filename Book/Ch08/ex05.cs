using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 8-5
 * 
 * 인덱서로 배열처럼 사용하는 제곱 클래스
 */

namespace Book.Ch08
{
    internal class ex05
    {
        class SquareCalculator
        {
            public int this[int i]
            {
                get
                {
                    return i + 1;
                }
            }
        }

        static void Main5(string[] args)
        {
            SquareCalculator square = new SquareCalculator();
            Console.WriteLine(square[10]);
        }
    }
}
