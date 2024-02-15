using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 9-17
 * 
 * @기호를 사용한 문자열(Verbatim String : 축자 문자열)
 */

namespace Book.Ch09
{
    internal class ex17
    {
        static void Main17(string[] args)
        {
            File.WriteAllText(@"C:\test\test.txt", "문자열을 파일에 씁니다");
        }
    }
}
