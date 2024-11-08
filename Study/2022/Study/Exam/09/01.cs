﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.08.04
 * 내용 : 피보나치 연습문제
 */

namespace Exam._09
{
    internal class _09_01
    {
        static void Main1(string[] args)
        {
            int[] arr1 = { 5, 25, 75, 35, 15 };
            PrintArray(arr1);

            int[] arr2 = (int[])arr1.Clone();
            PrintArray(arr2);

            int[] arr3 = new int[10];
            arr1.CopyTo(arr3, 3);
            PrintArray(arr3);

            Array.Sort(arr1);
            PrintArray(arr1);

            Array.Reverse(arr1);
            PrintArray(arr1);
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i],2}\t");
            }
            Console.WriteLine();
        }
    }
}
