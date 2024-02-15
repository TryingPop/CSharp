using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 9-18
 * 
 * 파일 읽기
 */

namespace Book.Ch09
{
    internal class ex18
    {
        static void Main18(string[] args)
        {
            File.WriteAllText(@"C:\test\test.txt", "문자열을 파일에 씁니다.");
            // txt파일을 읽는 방법
            // 통으로 읽어 시스템에 부담이 간다
            Console.WriteLine(File.ReadAllText(@"C:\test\test.txt"));
        }
    }
}
