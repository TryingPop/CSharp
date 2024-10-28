using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 22
이름 : 배성훈
내용 : Overflow
    교재 p55 ~ 56
    
    오버플로우에 관한 내용이다
    최저값보다 작은 데이터는 언더플로우로 명시했다
*/

namespace Study._2024.Ch03
{
    internal class _04_Overflow
    {

        static void Main4(string[] args)
        {

            // uint a = uint.MaxValue;
            int a = int.MaxValue;
            Console.WriteLine(a);       // 주석 : 4_294_967_295
                                        // 2_147_483_647

            a = a + 1;                  

            Console.WriteLine(a);       // 주석 : 0
                                        // -2_147_483_648
        }
    }
}
