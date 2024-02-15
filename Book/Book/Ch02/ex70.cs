using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-70
 * 
 * int 자료형 최솟값의 음수
 */

namespace Book.Ch02
{
    internal class ex70
    {
        static void Main70(string[] args)
        {
            int output = int.MinValue;
            // output에 음수를 붙여도 오류는 나오지않으며
            // 변환이 안돼서 자기자신이 나온다
            Console.WriteLine("{0}", -output);
            
            // Console.WriteLine(-(-2147483648));
            // 반면 위처럼 직접 입력하면 오류 문구가 생긴다
        }
    }
}
