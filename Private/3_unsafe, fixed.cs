using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Private
{
    internal class _3_unsafe__fixed
    {
        struct Pointer
        {
            public int x;
            public int y;

            public override string ToString()
            {
                return $"x : {this.x}, y : {this.y}";
            }
        }
        

        static void Main3(string[] args)
        {
            // 솔루션에서 해당 cs파일이 있는 프로젝트 우측클릭 > 속성 클릭 > 빌드의 일반 파트에서 > 안전하지 않은 코드 체크!
            // 그러면 unsafe 사용 가능
            // CLR에서 메모리를 스스로 관리해서 사용자가 직접 다룰 수 없다
            // *를 이용해 유저가 메모리를 직접 건드리므로 안전한지 안안전한지 알 수 없다.
            // 이를 나타내는 명령어가 unsafe

            int a = 0;
            int b = 0;
            float c = 0.0f;

            string d = "AA";
            string e = "AA";

            int[] f = { 0, 2 };

            /*
            unsafe
            {
                Pointer pointer;
                // 주소값을 담는 방법 
                Pointer* p = &pointer;

                p->x = 3; // *p.x = 3;
                p->y = 4; // *p.y = 4;

                Console.WriteLine(pointer);

                int* pa = &a;
                int* pb = &b;
                float* pc = &c;

                IntPtr ipa = new IntPtr(pa);
                IntPtr ipb = new IntPtr(pb);
                IntPtr ipc = new IntPtr(pc);

                Console.WriteLine($"a : {ipa}");
                Console.WriteLine($"b : {ipb}");
                Console.WriteLine($"c : {ipc}");

                a = 20;
                b = 30;
                c = 3.14f;

                Console.WriteLine($"a : {ipa}");
                Console.WriteLine($"b : {ipb}");
                Console.WriteLine($"c : {ipc}");
                // 메모리 고정
                // GC는 예기치 않게 변수를 재배치할 수 있다.
                // string, object etc...
                fixed (char* pd = d)
                fixed (char* pe = e)
                fixed (int* pf = f) // pd, pe, pf는 { }안에서만 정의된다.
                {
                    IntPtr ipd = new IntPtr(pd);
                    IntPtr ipe = new IntPtr(pe);
                    IntPtr ipf = new IntPtr(pf);

                    Console.WriteLine($"AA : {ipd}");
                    Console.WriteLine($"AA : {ipe}");
                    Console.WriteLine($"f  : {ipf}");
                }
            

            }*/



        }
    }
}
