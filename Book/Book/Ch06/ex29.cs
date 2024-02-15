using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 6-29
 * 
 * 일반적인 속성
 */

namespace Book.Ch06
{

    internal class ex29
    {
        class Box
        {
            public int width;
            public int height;

            public int Width
            {
                get 
                { 
                    return this.width; 
                }
                set 
                {   
                    if (value > 0)
                    {
                        this.width = value;
                    }
                    else
                    {
                        Console.WriteLine("너비는 자연수를 입력해주세요");
                    }
                }
            }

            public int Height
            {
                get 
                { 
                    return this.height; 
                }
                set 
                {
                    if (value > 0)
                    {
                        this.height = value;
                    }
                    else
                    {
                        Console.WriteLine("높이는 자연수를 입력해주세요");
                    }
                }
            }

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

        static void Main29(string[] args)
        {

            Box box = new Box(10, 10);

            box.width = -10;
            box.Width = -100;
            box.Height = -200;
        }
    }
}