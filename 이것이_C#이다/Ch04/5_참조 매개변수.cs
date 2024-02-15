using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 메서드 실습하기 교재 p256
 * 
 */

namespace Ch04
{
    internal class _5_참조_매개변수
    {
        static void Main5(string[] args)
        {
            int num1 = 10;
            int num2 = 3;
            int num3 = 0;
            int num4 = 0;

            // point 개념
            // ref 메모리 주소를 전달
            // 메서드에서 한 개 이상의 값을 리턴하기 위해 자주 사용
            MyDivider(num1, num2, ref num3, ref num4);
            
            Console.WriteLine("num3 : {0}", num3);
            Console.WriteLine("num4 : {0}", num4);


        } // end of Main

        public static void MyDivider(int n1, int n2, ref int result1, ref int result2)
        {
            result1 = n1 / n2;
            result2 = n1 % n2;
        }
    }
    
}
