using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : 일반화 메소드
    교재 p 405 ~ 409

    특수한 개념으로부터 공통된 개념을 찾아 묶는 것을 일반화(Generalization)라고 한다.
    일반화 프로그래밍(Generic Programming)은 이러한 일반화를 이용하는 프로그램 기법이다.
    일반화의 대상은 데이터 형식(Data Type)이다

    일반화 메소드(Generic Method)는 데이터 형식을 일반화한 메소드이다.
    일반화 메소드는 형식이의 이름 대신 형식 매개변수(Type Parameter)가 들어간다.
*/

namespace Study._2024.Ch11_일반화.코드
{
    internal class _01_CopyingArray
    {

        static void CopyArray<T>(T[] source, T[] target)
        {

            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }

        static void Main1(string[] args)
        {

            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];

            CopyArray<int>(source, target);

            // 1 2 3 4 5
            foreach(int element in target)
                Console.WriteLine(element);

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯" };
            string[] target2 = new string[source2.Length];

            CopyArray<string>(source2, target2);

            // 하나 둘 셋 넷 다섯
            foreach(string element in target2)
                Console.WriteLine(element);
        }
    }
}
