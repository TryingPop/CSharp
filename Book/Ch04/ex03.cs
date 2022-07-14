using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-3
 * 
 * 기본적인 배열 생성 방법
 */

namespace Book.Ch04
{
    internal class ex03
    {
        static void Main3(string[] args)
        {
            int[] intArray = { 52, 273, 32, 65, 103 };
            long[] longArray = { 52, 273, 32, 65, 103 };
            float[] floatArray = { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f };
            double[] doubleArray = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            char[] charArray = { '가', '나', '다', '라' };
            string[] stringArray = { "윤인성", "연하진", "윤아린" };

            /*
            // 앞에서 float형 array라고 정의해줘서 뒤에 f를 붙이지 않아도
            // 알아서 float형으로 변수 할당
            float[] exArray = { 2, 3, 5 };
            foreach (float num in exArray)
            {
                Console.WriteLine(num);
                Console.WriteLine(num.GetType());
            }
            */

        }
    }
}
