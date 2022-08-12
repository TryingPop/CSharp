using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 메서드 실습하기 교재 p275
 * 
 * 메서드 오버로드(Overloadd)
 *  - 같은 이름을 가진 메서드를 매개변수(Parameter)로 구분한 메서드
 *  - 메서드 반환값은 오버로드 메서드에 영향을 미치지 않음
 */

namespace Ch04
{
    internal class _3_메서드_오버로드
    {
        // 매개변수로 메서드를 구분할 수 있다
        // 반환타입으로는 안된다 오직 매개변수만!
        // 이렇게 구분하는걸 오버로드

        static void Main(string[] args)
        {
            int r1 = Plus(1, 2);
            int r2 = Plus(1, 2, 3);

            double r3 = Plus(1, 2.2);
            string r4 = Plus("Hello", "World");

            Console.WriteLine("{0}", r1);
            Console.WriteLine("{0}", r2);
            Console.WriteLine("{0}", r3);
            Console.WriteLine("{0}", r4);
            Console.WriteLine();

            // 비교 주의!

            // Ex1
            // Ex1();
            // Console.WriteLine(Ex1());
            // 코드 2개 모두 함수 구분이 힘들다고
            // 런타임 실행 불가 메세지 나온다

            // Console.WriteLine(Ex1(2.0)); 
            // a가 int인데 double을 못 넣는다


            // Ex2
            // 입력받는 변수 타입에 맞춰 실행한다
            // Ex2(); 
            // 역시 런타임 실행 안된다
            Console.Write($"{Ex2(2.0)},  ");
            Console.WriteLine("{0}", Ex2(2.0).GetType());
            Console.Write($"{Ex2(2)},  ");
            Console.WriteLine("{0}", Ex2(2).GetType());
            Console.WriteLine();

            Ex3();
            // Console.WriteLine(Ex3());
            // void라 못불러온다
            Console.WriteLine();

            Ex4();
            Console.WriteLine(Ex4());

        } // end of Main

        public static int Plus(int a = 0, int b = 2)
        {
            return a + b;
        }
        
        public static int Plus(int a, int b, int c)
        {
            return a + b + c;
        }

        public static double Plus(double a = 0, double b = 1)
        {
            return a + b;
        }

        public static string Plus(string a, string b)
        {
            return a + b;
        }


        // 비교용
        // Ex1
        public static int Ex1(int a = 0, int b = 1)
        {
            return a + b;
        }
        public static double Ex1(int a = 0, double b = 2)
        {
            return a + b;
        }

        // Ex2
        public static int Ex2(int a = 0, int b = 1)
        {
            return a + b;
        }

        public static double Ex2(double a = 0, double b = 2)
        {
            return a + b;
        }

        public static int Ex3(long a = 0, int b = 1)
        {
            return (int)a + b;
        }

        // Ex3
        public static void Ex3()
        {
            Console.WriteLine("함정용");
        }

        public static int Ex3(int a = 0, int b = 1)
        {
            return a + b;
        }

        // Ex4
        public static int Ex4(int a = 0, int b = 2)
        {
            return a + b;
        }
        
    }
}
