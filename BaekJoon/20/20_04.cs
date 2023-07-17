using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*
날짜 : 2023. 7. 18
이름 : 배성훈
내용 : 프린터 큐
    문제번호 : 1966번
*/
namespace BaekJoon._20
{
    internal class _20_04
    {

        static void Main4(string[] args)
        {

            // 문제 개수
            int len = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < len; i++)
            {

                // 0 : 입력 받을 수열의 길이, 1 : 찾을 인덱스
                int[] info = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                // 수열 입력
                int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                int count = 1;

                // j보다 크거나 같은 문자열들 찾기!
                for (int j = 0; j < inputs.Length; j++)
                {

                    if (inputs[info[1]] < inputs[j])
                    {

                        count++;
                    }
                    // else if (inputs[info[1]] == inputs[j] && i < j)
                    // {

                    //      count++;
                    // }
                }

                sb.AppendLine(count.ToString());
            }

            Console.WriteLine(sb);
        }
    }
}
