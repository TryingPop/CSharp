using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-46
 * 
 * GetType 메서드 활용
 */

namespace Book.Ch02
{
    internal class ex46
    {
        static void Main46(string[] args)
        {
            // 변수 선언
            int _int = 273;
            long _long = 522731033265;
            float _float = 52.273f;
            double _double = 52.273;

            // 출력
            // System.type이 출력된다
            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            
        }
    }
}
