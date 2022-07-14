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

            // 함정용이 있을시 함정용이 발동한다
            Ex();

            // Console.WriteLine(Ex());
            // void 반환이라 코드 실행 불가능
            
            // double과 int처럼 구분해야하는 숫자면 
            // Ex2(2);
            
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
        public static void Ex()
        {
            Console.WriteLine("함정용");
        }

        public static int Ex(int a = 0, int b = 1)
        {
            return a + b;
        }


        // 비교용2
        public static int Ex2(int a = 0, int b = 1)
        {
            return a + b;
        }

        public static double Ex2(double a = 0, double b = 1)
        {
            return a + b;
        }
    }
}
