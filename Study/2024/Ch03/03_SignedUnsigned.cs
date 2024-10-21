using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 21
이름 : 배성훈
내용 : SignedUnsigned
    교재 p 51 ~ 54

    정수 자료형에 부호 비트에 관한 설명과 보수법에 관련된 내용이 있다
        sbyte x = 0b1111_1111;
    맨 처음 1은 부호비트이고, 뒤에 7자리의 비트는 값을 표기하는 비트이다
    보수법은 0b1111_1111의 값은 앞이 음수이고 111_1111이 가장 큰 수 127이 아닌가 생각할 수 있지만
    양수 값과 더했을 때 0이 되는 값에 부호를 씌운다는 의미이다
    즉 -0b0000_0001 = -1이다
*/

namespace Study._2024.Ch03
{
    internal class _03_SignedUnsigned
    {

        static void Main3(string[] args)
        {

            byte a = 255;
            sbyte b = (sbyte)a;

            Console.WriteLine(a);   // 255
            Console.WriteLine(b);   // -1
        }
    }
}
