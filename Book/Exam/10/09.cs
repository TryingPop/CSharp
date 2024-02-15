

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.08.05
 * 내용 : 피보나치 연습문제
 */

namespace Exam._10
{
    internal class _10_09
    {
        public class Saram
        {
            public virtual void Print()
            {
                Console.WriteLine("사람 입니다.");
            }
        }

        public class Man : Saram
        {
            public override void Print()
            {
                Console.WriteLine("남자 입니다.");
            }
        }

        public class Woman : Saram
        {
            public override void Print()
            {
                Console.WriteLine("여자 입니다.");
            }
        }

        static void Main9(string[] args)
        {
            Saram s1 = MakeSaram(1);
            Saram s2 = MakeSaram(2);

            s1.Print();
            s2.Print();
        }

        public static Saram MakeSaram(int kind)
        {
            if (kind == 1)
            {
                return new Man();
            }
            else
            {
                return new Woman();
            }
        }
    }
}
