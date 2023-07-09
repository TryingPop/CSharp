using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 7. 9
이름 : 배성훈
내용 : 회의실 배정
    문제번호 : 1931번
*/

namespace BaekJoon._13
{
    internal class _13_02
    {

        public static int SortTimes(int[] x, int[] y) 
        {

            int rs1 = x[0].CompareTo(y[0]);
            int rs2 = x[1].CompareTo(y[1]);

            return rs1 != 0? rs1 : rs2;
        }


        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int length = int.Parse(sr.ReadLine());

            // 가변 배열
            int[][] times = new int[length][];

            for (int i = 0; i < length; i++)
            {

                times[i] = Array.ConvertAll(sr.ReadLine().Split(' '), item => int.Parse(item));
            }


        }
    }
}
