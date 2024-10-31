using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 구조체
    교재 p 279 ~ 282

    복합 데이터 형식에는 클래스 말고도 구조체(Sturcture)가 있다.
    구조체는 struct 키워드를 이용해 선언한다.

    구조체는 데이터를 담기 위한 자료구조로 사용된다.
    따라서 굳이 은닉성을 비롯한 객체지향의 원칙을 구조체에 강하게 적용하지 않는 편이며,
    편의를 위해 public 으로 선언해서 사용하는 경우가 많다.

    구조체 인스턴스는 스택에 할당되고 인스턴스가 선언된 블록이 끝나는 지점의 메모리에서 사라진다.
    인스턴스의 사용이 끝나면 즉시 메모리에서 제거된다는 점과 가비지 콜렉터를 덜 귀찮게 한다는 점에서 구조체는 클래스에 비해 성능의 이점을 가진다.

    구조체는 값 형식이기에 할당 연산자 =를 통해 모든 필드가 그대로 복사된다.
    구조체는 new 연산자 없이 선언만해도 CLR이 기본값으로 초기화를 해준다.
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _17_Structure
    {

        struct Point3D
        {

            public int X;
            public int Y;
            public int Z;

            public Point3D(int X, int Y, int Z)
            {

                this.X = X;
                this.Y = Y;
                this.Z = Z;
            }

            public override string ToString()
            {

                return string.Format($"{X} {Y} {Z}");
            }
        }

        static void Main17(string[] args)
        {

            Point3D p3d1;
            p3d1.X = 1;
            p3d1.Y = 20;
            p3d1.Z = 40;

            Console.WriteLine(p3d1.ToString()); // 1 20 40

            Point3D p3d2 = new Point3D(40, 20, 1);
            Point3D p3d3 = p3d2;
            p3d3.Z = 100;

            Console.WriteLine(p3d2.ToString()); // 40 20 1
            Console.WriteLine(p3d3.ToString()); // 40 20 100
        }
    }
}
