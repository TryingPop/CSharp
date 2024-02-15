using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.12
 * 내용 : 코드 2-32
 * 
 * sizeof 연산자
 */

namespace Book.Ch02
{
    internal class ex32
    {
        static void Main32(string[] args)
        {
            // sizeof를 통해 크기를 알 수 있다
            Console.WriteLine("int : " + sizeof(int));
            Console.WriteLine("long : " + sizeof(long));
            Console.WriteLine("float : " + sizeof(float));
            Console.WriteLine("double : " + sizeof(double));
            Console.WriteLine("char : " + sizeof(char));
        }
    }
}
