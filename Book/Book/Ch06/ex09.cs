using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 6-9
 * 
 * 클래스 메서드에서는 클래스 변수 사용만 사용 가능
 */

namespace Book.Ch06
{
    internal class ex09
    {
        public static int instanceVariable = 10;

        static void Main9(string[] args)
        {
            Console.WriteLine(instanceVariable); 
        }
    }
}
