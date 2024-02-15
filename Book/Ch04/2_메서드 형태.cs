using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 메서드 실습하기 교재 p265
 * 
 */

namespace Ch04
{
    internal class _2_메서드_형태
    {
        static void Main2(string[] args)
        {
            // 메서드 호출
            // 0.12 를 인자라고 말한다
            double t1 = Type1(0.12);

            Console.WriteLine("t1 : {0}", t1);

            Type2(true);
            Type2(false);

            string t3 = Type3();
            Console.WriteLine(t3);

            Type4();

        } // end of Main

        // Type1 : 매개변수 O, 리턴값 O
        public static double Type1(double x)
        {
            double y = x + Math.PI;
            return y;
        }

        // Type2 : 매개변수 O, 리턴값 X
        public static void Type2(bool status)
        {
            if (status)
            {
                Console.WriteLine("참 입니다.");
            }
            else
            {
                Console.WriteLine("거짓 입니다.");
            }
        }
        // Type3 : 매개변수 X, 리턴값 O
        public static string Type3()
        {
            int n1 = 1;
            int n2 = 2;

            if (n1 > n2)
            {
                return "n1 은 n2 보다 크다.";
            }
            else
            {
                return "n1 은 n2 보다 작다.";
            }
        }
        // Type4 : 매개변수 X, 리턴값 X
        public static void Type4()
        {
            Console.Write("입력 : ");
            Console.ReadLine();
            Console.WriteLine("...?");
        }
    }
}
