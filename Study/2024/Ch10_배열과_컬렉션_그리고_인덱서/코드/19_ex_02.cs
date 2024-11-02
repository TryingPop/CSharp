using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : 연습문제 2
    교재 p 401

    두 행렬의 곱은 다음과 같이 계산한다
    
        A = { { a, b }, { c, d } }
        B = { { e, f }, { g, h } }

        A x B = { { a * e + b * g, a * f + b * h }, 
                { c * e + d * g, c * f + d * h } }

    다음 두 행렬 A와 B의 곱을 2차원 배열을 이용하여 계산하는 프로그램을 작성하세요.
        A = { { 3, 2 }, { 1, 4 } }, B = { { 9, 2 }, { 1, 7 } }
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{
    internal class _19_ex_02
    {

        static void Main19(string[] args)
        {

            int[,] A = new int[2, 2] { { 3, 2 }, { 1, 4 } };
            int[,] B = new int[2, 2] { { 9, 2 }, { 1, 7 } };

            int[,] ret = MatMul(A, B);
            for (int i = 0; i < ret.GetLength(0); i++)
            {

                for (int j = 0; j < ret.GetLength(1); j++)
                {

                    Console.Write($"{ret[i, j]} ");
                }

                Console.WriteLine();
            }

            int[,] MatMul(int[,] _f, int[,] _b)
            {

                int[,] ret = new int[2, 2];
                ret[0, 0] = _f[0, 0] * _b[0, 0] + _f[0, 1] * _b[1, 0];
                ret[0, 1] = _f[0, 0] * _b[0, 1] + _f[0, 1] * _b[1, 1];
                ret[1, 0] = _f[1, 0] * _b[0, 0] + _f[1, 1] * _b[1, 0];
                ret[1, 1] = _f[1, 0] * _b[0, 1] + _f[1, 1] * _b[1, 1];
                return ret;
            }
        }
    }
}
