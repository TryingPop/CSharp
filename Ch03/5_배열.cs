using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 배열 실습하기 교재 p
 * 
 */

namespace Ch03
{
    internal class _5_배열
    {
        static void Main5(string[] args)
        {
            // 배열
            // new : 인스턴스 생성 연산
            int[] arr1 = new int[3];
            // 배열에서 값을 지정안하면 초기값으로 0을 갖는다
            // Console.WriteLine(arr1[0]);
            // 0 값이 출력된다

            // 배열 변수를 출력하면 배열 형태가 나온다
            // Console.WriteLine(arr1);
            // System.int32[] 가 출력된다

            // arr 정의할 때 원소 자료형들 정의했다
            arr1[0] = 1;
            arr1[1] = 2;
            arr1[2] = 3;

            // 원소를 바로 정의
            int[] arr2 = { 1, 2, 3, 4, 5 };

            string[] arr3 = { "서울", "대전", "대구", "부산", "광주" };

            // 배열 원소 출력
            // 인덱스 번호로 가져온다
            Console.WriteLine("arr1의 1번째 원소 : {0}", arr1[0]);
            Console.WriteLine("arr2의 3번째 원소 : {0}", arr2[2]);
            Console.WriteLine("arr3의 4번째 원소 : {0}", arr3[3]);

            // 배열 길이
            Console.WriteLine("arr1 배열 길이 : {0}", arr1.Length);


            // 배열 반복문
            // 배열의 길이만큼 반복
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("arr[{0}] : {1}", i, arr1[i]);
            }

            // foreach
            // 배열에서 자주 사용
            foreach (int num in arr2)
            {
                Console.WriteLine("arr2[{1}] : {0}", num, Array.IndexOf(arr2, num));
            }


            foreach (string city in arr3)
            {
                Console.Write("{0}  ", city);
            }

            Console.WriteLine();

            // 배열은 크기가 정해지면 못바꾼다
            // 그래서 크기 변환이 가능한 리스트를 이용할 수 있다

            // 1차원 배열
            int[] arr1d = { 10, 20, 30, 40, 50 };

            int total = 0;

            foreach (int num in arr1d)
            {
                total += num;
            }

            Console.WriteLine("arr1d의 총합: {0}", total);

            // 2차원 배열
            // 직사각형 모양만 받는다
            // 이외 모양은 안받는다
            // python 리스트와 달리 pandas의 df처럼 [ㅇ, ㅇ]값으로 찾아낸다
            int[,] arr2d = { { 1, 2, 3, 4 }, 
                             { 5, 6, 7, 8 }, 
                             { 9, 10, 11, 12 } };


            foreach (int i in arr2d)
            {
                Console.WriteLine("{0}", i);
            }

            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    int ele = arr2d[i, j];
                    Console.WriteLine("arr2d[{0},{1}] = {2}", i, j, ele);
                }
            }


            // 3차원 배열
            int[,,] arr3d = { { { 1, 2, 3 }, 
                                { 4, 5, 6 }, 
                                { 7, 8, 9 } 
                              }, 
                              { { 10, 11, 12 }, 
                                { 13, 14, 15 }, 
                                { 16, 17, 18 } 
                              }, 
                              { { 19, 20, 21 }, 
                                { 22, 23, 24 }, 
                                { 25, 26, 27 } 
                              } 
                            };

            // arr3d 에서 3, 5, 11, 17, 25 값 원소 추출하기
            Console.WriteLine("arr3d[0, 0, 2] : {0}", arr3d[0, 0, 2]);
            Console.WriteLine("arr3d[0, 1, 1] : {0}", arr3d[0, 1, 1]);
            Console.WriteLine("arr3d[1, 0, 1] : {0}", arr3d[1, 0, 1]);
            Console.WriteLine("arr3d[1, 2, 1] : {0}", arr3d[1, 2, 1]);
            Console.WriteLine("arr3d[2, 2, 0] : {0}", arr3d[2, 2, 0]);




        }
    }
}
