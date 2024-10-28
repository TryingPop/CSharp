using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 열거 형식
    교재 p83 ~ 84

    숫자 비교보다 가독성이 좋다
*/

namespace Study._2024.Ch03
{
    internal class _19_Enum2
    {

        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

        static void Main19(string[] args)
        {

            DialogResult result = DialogResult.YES;

            Console.WriteLine(result == DialogResult.YES);      // True
            Console.WriteLine(result == DialogResult.NO);       // False
            Console.WriteLine(result == DialogResult.CANCEL);   // False
            Console.WriteLine(result == DialogResult.CONFIRM);  // False
            Console.WriteLine(result == DialogResult.OK);       // False
        }
    }
}
