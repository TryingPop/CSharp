using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.22
 * 내용 : 코드 6-26
 * 
 * Box 클래스
 */

namespace Book.Ch06
{

    internal class ex26
    {
        class Box
        {
            public int width;
            public int height;

            public Box(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

            public int Area()
            {
                return this.width * this.height;
            }
        }

        static void Main26(string[] args)
        {

            Box box = new Box(10, 10);

            box.width = -10;
        }
    }
}