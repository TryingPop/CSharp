﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 3-5
 * 
 * 홀수 짝수 구분하기
 */

namespace Book.Ch03
{
    internal class ex05
    {
        static void Main5(string[] args)
        {
            Console.Write("숫자 입력 : ");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0) 
            {
                Console.WriteLine("{0} 은 짝수입니다.", input);
            } else
            {
                Console.WriteLine("{0} 은 홀수입니다.", input);
            }
        }
    }
}
