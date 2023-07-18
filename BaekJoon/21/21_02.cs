using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 7. 19
이름 : 배성훈
내용 : 문자열 집합
    문제번호 : 14425번
*/

namespace BaekJoon._21
{
    internal class _21_02
    {

        static void Main2(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int[] info = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            
            HashSet<string> mySet = new HashSet<string>();
            
            for (int i = 0; i < info[0]; i++)
            {

                mySet.Add(sr.ReadLine());
            }

            int result = 0;
            for (int i = 0; i < info[1]; i++)
            {

                if (mySet.Contains(sr.ReadLine()))
                {

                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
