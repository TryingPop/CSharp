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
    internal class _10_01
    {
        class Box
        {
            private double width;
            private double height;
            private double depth;

            public Box(double width, double height, double depth)
            {
                this.width = width;
                this.height = height;
                this.depth = depth;
            }

            public double Volume()
            {
                return width * height * depth;
            }
        }

        static void Main1(string[] args)
        {
            Box box1 = new Box(10, 20, 30);
            Box box2 = new Box(3, 6, 9);

            Console.WriteLine($"box1 부피 : {box1.Volume()}");
            Console.WriteLine($"box2 부피 : {box2.Volume()}");
        }

    }
}
