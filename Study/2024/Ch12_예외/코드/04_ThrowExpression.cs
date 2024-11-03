using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 3
이름 : 배성훈
내용 : 예외 던지기
    교재 p 440 ~ 441

    throw는 문으로 사용하지만 C# 7.0부터는 식(Expression)으로도 사용할 수 있도록 개선되었다.
*/

namespace Study._2024.Ch12_예외.코드
{
    internal class _04_ThrowExpression
    {

        static void Main4(string[] args)
        {

            // System.ArgumentNullException: Value cannot be null.
            try
            {

                int? a = null;
                int b = a ?? throw new ArgumentNullException();
            }
            catch (ArgumentNullException e)
            {

                Console.WriteLine(e);
            }

            // System.IndexOutOfRangeException: Index was outside the bounds of the array.
            try
            {

                int[] array = new[] { 1, 2, 3 };
                int index = 4;
                int value = array[

                    index >= 0 && index < 3 ? index : throw new IndexOutOfRangeException()
                    ];
            }
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine(e);
            }
        }
    }
}
