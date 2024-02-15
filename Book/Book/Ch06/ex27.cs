using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.22
 * 내용 : 코드 6-27
 * 
 * 변수 width와 height를 건드리지 못하게 수정
 */

namespace Book.Ch06
{

    internal class ex27
    {
        class Box
        {
            public int width;
            public int height;

            public Box(int width, int height)
            {
                if (width > 0 || height > 0)
                {
                    this.width = width;
                    this.height = height;
                }
                else
                {
                    Console.WriteLine("너비와 높이는 자연수로 초기화해주세요!");
                }
            }

            public int Area()
            {
                return this.width * this.height;
            }
        }

        static void Main27(string[] args)
        {

            Box box = new Box(10, 10);

            box.width = -10;
        }
    }
}