using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : 관계 연산자
    교재 p123 ~ 

    < : 왼쪽 피연산자가 오른쪽 피연산자보다 작으면 참, 아니면 거짓
    > : 왼쪽 피연산자가 오른쪽 피연산자보다 크면 참, 아니면 거짓
    <= : 왼쪽 피연산자가 오른쪽 피연산자보다 크거나 같으면 참, 아니면 거짓
    >= : 왼쪽 피연산자가 오른쪽 피연산자보다 작거나 같으면 참, 아니면 거짓
    == : 왼쪽 피연산자가 오른쪽 피연산자와 같으면 참, 아니면 거짓
    != : 왼쪽 피연산자가 오른쪽 피연산자와 다르면 참, 아니면 거짓
*/

namespace Study._2024.Ch04
{
    internal class _04_RelationalOperator
    {

        static void Main4(string[] args)
        {

            Console.WriteLine($"3 > 4 : {3 > 4}");      // False
            Console.WriteLine($"3 >= 4 : {3 >= 4}");    // False
            Console.WriteLine($"3 < 4 : {3 < 4}");      // True
            Console.WriteLine($"3 <= 4 : {3 <= 4}");    // True
            Console.WriteLine($"3 == 4 : {3 == 4}");    // False
            Console.WriteLine($"3 != 4 : {3 != 4}");    // True
        }
    }
}
