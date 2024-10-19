using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 10-12
 * 
 * Box 클래스 예외 관련 구현
 */

namespace Book.Ch10
{
    internal class ex12
    {
        class Box 
        {
            private int width;
            // Property
            // void형이 안되는 메소드로 보면 된다
            // 메모리상에 안올라가서 ref, out할 수 없다
            // override, abstract, virtual 선언 가능!
            public int Width
            {
                get { return this.width; }
                set
                {
                    if (value > 0)
                    {
                        this.width = value;
                    }
                    else
                    {
                        throw new Exception("너비는 자연수를 입력해주세요.");
                    }
                }
            }

            private int height;
            public int Height 
            {
                get { return this.height; }
                set
                {
                    if (value > 0)
                    {
                        this.height = value;
                    }
                    else
                    {
                        throw new Exception("높이는 자연수를 입력해주세요.");
                    }
                }
            }

            public Box(int width, int height)
            {
                this.Width = width;
                this.Height = height;
            }

            public int Area() { return this.width * this.height; }
        }

        static void Main12(string[] args)
        {
            Box box = new Box(-10, -20);
        }
    }
}
