using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-52
 * 
 * var 키워드를 사용한 다양한 자료형 선언
 */

namespace Book.Ch02
{
    internal class ex52
    {
        static void Main52(string[] args)
        {
            // long 타입
            var numberA = 100l;
            // Double 타입
            var numberB = 100.0;
            // float 타입
            var numberC = 100.0f;

            Console.WriteLine("numberA : {0}", numberA.GetType());
            Console.WriteLine("numberB : {0}", numberB.GetType());
            Console.WriteLine("numberC : {0}", numberC.GetType());
            
        }
    }
}
