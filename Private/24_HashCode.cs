using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.08.12
 * 내용 : HashCode
 */


namespace Private
{
    internal class _24_HashCode
    {
        public struct Struct1 { }
        public struct Struct2
        {
            public int a, b, c, d, e, f, g;
            public long A, B, C, D, E, F, G, H;
        }
        public struct Struct3
        {
            public int i1, i2, i3, i4, i5, i6, i7, i8;
            public long l1, l2, l3, l4, l5, l6, l7, l8;
            public double d1, d2, d3, d4, d5, d6, d7, d8;
        }

        public class Class1 { }
        public class Class2
        {
            public int a, b, c, d, e, f, g;
            public long A, B, C, D, E, F, G, H;
        }
        public class Class3
        {
            public int i1, i2, i3, i4, i5, i6, i7, i8;
            public long l1, l2, l3, l4, l5, l6, l7, l8;
            public double d1, d2, d3, d4, d5, d6, d7, d8;
        }

        public class Example
        {
            public int a, b, c;

            public Example(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public override int GetHashCode()
            {
                return this.a.GetHashCode() + this.b.GetHashCode();
            }

            // Equals를 재정의할 때는 분할 정의를 따라야한다!
            // Reflexive, Symmetric, Transitive
            // 그리고 여기에 추가로 일관성!

            public override bool Equals(object? obj)
            {
                if (this.a == (obj as Example)?.a && this.b == (obj as Example)?.b)
                { 
                    return true; 
                }
                return false;
            }

        }

        public static bool CompareToExample(Example ex1, Example ex2)
        {
            return ex1.Equals(ex2);
        }

        public static bool CompareToExampleHC(Example ex1, Example ex2)
        {
            return ex1.GetHashCode() == ex2.GetHashCode();
        }

        static void Main24(string[] args)
        {
            var A = new Example(1, 2, 1);
            var B = new Example(1, 2, 2);

            if (CompareToExample(A, B))
            {
                Console.WriteLine("같다");
            }
            if (CompareToExampleHC(A, B))
            {
                Console.WriteLine("해쉬 같다");
            }

            A.a = 2;
            if (CompareToExample(A, B))
            {
                Console.WriteLine("같다");
            }
            else
            {
                Console.WriteLine("다르다");
            }

            if (CompareToExampleHC(A, B))
            {
                Console.WriteLine("해쉬 같다");
            }
            else
            {
                Console.WriteLine("해쉬 다르다");
            }
        }

    }
}

// 참고 사이트
// https://tsyang.tistory.com/11
// https://100100e.tistory.com/352
// https://rito15.github.io/posts/cs-gethashcode-cost-by-types/