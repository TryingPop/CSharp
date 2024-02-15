using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 9-16
 * 
 * 파일에 문자열 쓰기
 */

namespace Book.Ch09
{
    internal class ex16
    {
        static void Main16(string[] args)
        {
            // 경로에 폴더가 없을 경우 에러를 호출한다
            // 파일이 없는 경우면 새로 생성한다
            File.WriteAllText("C:\\test\\test.txt", "문자열을 파일에 씁니다");
        }
    }
}
