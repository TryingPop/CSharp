using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 7. 12
이름 : 배성훈
내용 : LCS
    문제번호 : 9251번
*/

namespace BaekJoon._14
{
    internal class _14_15
    {

        static void Main(string[] args)
        {

            string input0 = Console.ReadLine();
            string input1 = Console.ReadLine();

            Console.WriteLine(LCS(input0, input1));
        }

        public static int LCS(string str1, string str2)
        {

            if (str1 == "" || str2 == "")
            {

                return 0;
            }

            if (str1[str1.Length - 1] == str2[str2.Length - 1])
            {

                return LCS(str1.Remove(str1.Length - 1), str2.Remove(str2.Length - 1)) + 1;
            }

            return Math.Max(LCS(str1, str2.Remove(str2.Length - 1)), LCS(str1.Remove(str1.Length - 1), str2));
        }
    }
}
