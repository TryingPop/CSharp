using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.15
 * 내용 : 백준 4단계 1번 문제
 * 
 */

namespace BaekJoon._03
{
    internal class _04_06
    {
        static void Main(string[] args)
        {
            
            int length = int.Parse(Console.ReadLine());
            double avg = 0;
            int num = 0;
            double result = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                string[] strinputs = Console.ReadLine().Split(" ");

                int[] inputs = Array.ConvertAll(strinputs, int.Parse);
                int[] scorearr = new int[inputs.Length - 1];

                for(int j = 0; j < scorearr.Length; j++)
                {
                    scorearr[j] = inputs[j + 1];
                }

                avg = Math.Truncate(scorearr.Average()*10) / 10;

                num = 0;

                foreach (int score in inputs)
                {
                    if (score > avg )
                    {
                        num++;
                    }
                }

                result = (double) (100 * num) / (inputs.Length - 1);

                //Console.WriteLine("{0:0.000}%", result);   
                sb.Append(result.ToString("F3")+"%");

            }

            Console.WriteLine(sb);
        }

    }
}
