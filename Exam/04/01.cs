using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.22
 * 내용 : 피보나치 연습문제
 */

namespace Exam._04
{
    internal class _04_01
    {
        struct Point3D
        {
            public int x;
            public int y;
            public int z;

            public Point3D(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            
            public override string ToString()
            {
                return String.Format($"{this.x}, {this.y}, {this.z}");
            }
            

        }
        static void Main(string[] args)
        {
            Point3D p1;
            p1.x = 10;
            p1.y = 20;
            p1.z = 30;


            Console.WriteLine(p1.ToString);
            // 구조체 안에 tostring 메서드를 지우면 위치 이름만 나온다
            // 아래와 같이 실행하면 ToString 메서드 실행
            // cw에서 tostring 변환해서 사용하기에 tostring을 이용
            // Console.WriteLine(p1);

            Point3D p2 = new Point3D(100, 200, 300);
            Console.WriteLine(p2.ToString());
        }

    }
}
