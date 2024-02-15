using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 8-1
 * 
 * 제네릭 기본
 */

namespace Book.Ch08
{
    internal class ex01
    {
        class Wanted<T>
        {
            public T Value;
            public Wanted(T value)
            {
                this.Value = value;
            }
        }

        static void Main1(string[] args)
        {
            Wanted<string> wantedString = new Wanted<string>("String");
            Wanted<int> wantedInt = new Wanted<int>(52273);
            Wanted<double> wantedDouble = new Wanted<double>(52.273);

            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedDouble.Value);
        }
    }
}
