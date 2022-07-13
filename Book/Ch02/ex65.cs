using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-65
 * 
 * 기본 자료형을 분자열로 변환
 */

namespace Book.Ch02
{
    internal class ex65
    {
        static void Main65(string[] args)
        {
            Console.WriteLine((52).ToString());
            Console.WriteLine((52.273).ToString());
            Console.WriteLine(('a').ToString());
            // bool 타입은 string 자료형으로 변환하면 첫 글자는 대문자
            Console.WriteLine((true).ToString());
            Console.WriteLine((false).ToString());

            Console.WriteLine((52).ToString().GetType());
            Console.WriteLine((52.273).ToString().GetType());
            Console.WriteLine(('a').ToString().GetType());
            Console.WriteLine((true).ToString().GetType());
            Console.WriteLine((false).ToString().GetType());
        }
    }
}
