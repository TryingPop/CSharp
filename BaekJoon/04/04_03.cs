using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.15
 * 내용 : 백준 4단계 3번 문제
 * 
 */

namespace BaekJoon._03
{
    internal class _04_03
    {
        static void Main(string[] args)
        {
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            string d = (a * b * c).ToString();

            for (int i =0; i <= 9; i++)
            {
                int count = d.Count(f => f == i);
                Console.WriteLine(count);
            }
            */

            string[] exam = "1234512412".Split();
            foreach (var item in exam)
            {
                Console.WriteLine(item);
            }


        }
    }
}
