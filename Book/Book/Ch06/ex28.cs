using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 6-28
 * 
 * 겟터와 셋터
 */

namespace Book.Ch06
{

    internal class ex28
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

            // 겟터(Getter)
            public int GetWidth() 
            { 
                return this.width; 
            }
            public int GetHeight() 
            { 
                return this.height; 
            }

            // 셋터(Setter)
            public void SetWidth(int width)
            {
                if (width > 0) 
                { 
                    this.width = width; 
                }
                else 
                { 
                    Console.WriteLine("너비는 자연수를 입력해주세요"); 
                }
            }
            
            public void SetHeight(int height)
            {
                if (height > 0) 
                {
                    this.height = height; 
                }
                else 
                { 
                    Console.WriteLine("높이는 자연수를 입력해주세요"); 
                }
            }

            // 혹은 겟터 셋터를
            // public int Width
            // {
            //      get { return this.width; }
            //      set
            //      {
            //          if ( value > 0 )
            //          {
            //              this.width = value;
            //          }
            //          else
            //          {
            //              Console.WriteLine("너비는 자연수를 입력해주세요");
            //          }
            // public int Height
            // {
            //      get { return this.height; }
            //      set
            //      {
            //          if ( value > 0 )
            //          {
            //              this.height = value;
            //          }
            //          else
            //          {
            //              Console.WriteLine("높이는 자연수를 입력해주세요");
            //          }

            // public int width { set; get;} 
            // 코드를 입력하면 그냥 변수 생성과 같다
        }

        static void Main28(string[] args)
        {

            Box box = new Box(10, 10);

            box.width = -10;
        }
    }
}