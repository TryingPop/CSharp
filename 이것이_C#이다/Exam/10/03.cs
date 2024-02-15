
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.08.05
 * 내용 : 피보나치 연습문제
 */

namespace Exam._10
{
    internal class _10_03
    {
        class Adder
        {
            public int x;
            
            public Adder(int x)
            {
                this.x = x;
            }

            public void Add(int x)
            {
                this.x = x + 50;
            }

            public void Add(int[] arr)
            {
                arr[0]++;
            }

            public void Add(Adder a1)
            {
                a1.x = a1.x + 40;
            }

            public Adder Add(Adder a2, int value)
            {
                
                return new Adder(value);
            }
            
            // ??
            public void Add(out Adder a2, int value)
            {
                a2 = new Adder(value);
            }
            
        }


        static void Main3(string[] args)
        {
            int[] arr = { 10, 20, 30 };

            Adder adder = new Adder(100);

            adder.Add(100);
            Console.WriteLine($"1) {adder.x}");

            adder.Add(adder);
            Console.WriteLine($"2) {adder.x}");

            adder.Add(arr);
            Console.WriteLine($"3) {arr[0]}");

            adder = adder.Add(adder, 1);
            Console.WriteLine($"4) {adder.x}");

            adder.Add(out adder, 2);
            Console.WriteLine($"5) {adder.x}");
        }
    }
}
