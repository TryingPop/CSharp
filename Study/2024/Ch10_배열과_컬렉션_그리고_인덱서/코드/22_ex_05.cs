using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : 연습문제 5
    교재 p 402

    다음과 같은 결과를 출력하도록 아래의 코드를 완성하세요.
    
    출력 결과
        회사 : Microsoft
        URL : www.microsoft.com

    코드
        Hashtable ht = new Hashtable();
        
        // 1
            = "Microsoft";
        ht["URL"] = // 2

        Console.WriteLine("회사 : {0}", // 3
                );

        Console.WriteLine("URL : {0},   // 4
                );
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{
    internal class _22_ex_05
    {

        static void Main22(string[] args)
        {

            Hashtable ht = new Hashtable();

            ht["회사"] = "Microsoft";
            ht["URL"] = "www.microsoft.com";

            Console.WriteLine("회사 : {0}", ht["회사"]);
            Console.WriteLine("URL : {0}", ht["URL"]);
        }
    }
}
