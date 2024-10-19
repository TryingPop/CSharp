using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 조건문 if 실습하기 교재 p127
 * 
 */

namespace Ch03
{
    internal class _1_if문
    {
        static void Main1(string[] args)
        {
            //if
            int num1 = 1;
            int num2 = 2;
            
            /*
            if (조건)
            {
                // 조건이 참이면 실행
            }
            */

            if (num1 < num2)
            {
                Console.WriteLine("{0} 이 {1} 보다 작다", num1, num2);
            }

            if (num1 < 0)
            {
                Console.WriteLine("{0} 이 0 보다 작다", num1);
            }

            if (num1 > 0)
            {
                if (num2 > 1)
                {
                    Console.WriteLine($"{num1} 은 0 보다 크고, {num2} 는 1 보다 크다.");
                }
            }
            /* 앞과 같은 문법
            if (num1 > 0 && num2 > 1)
            {
                Console.WriteLine($"{num1} 은 0 보다 크고, {num2} 는 1 보다 크다.");
            }
             */


            //if - else
            //if문 보다 더 확장 시킴
            int var1 = 1;
            int var2 = 2;

            /*
            if (조건)
            {
                조건이 참일때 실행하는 코드
            } else
            {
                조건이 거짓일때 실행하는 코드
            }
            */

            if (var1 > var2)
            {
                Console.WriteLine($"{var1} 이 {var2} 보다 크다");
            } else
            {
                Console.WriteLine($"{var1} 이 {var2} 보다 작다");
            }

            // if - else if else
            int n1 = 1;
            int n2 = 2;
            int n3 = 3;
            int n4 = 4;

            /*
            if (A)
            {
                A조건이 참일 때 실행
            } else if (B) 
            {
                A조건이 거짓이고 B조건이 참일 때 실행
            } else
            {
                A조건이 거짓이고 B조건이 거짓일 때 실행
            }
            */

            if (n1 > n2)
            {
                Console.WriteLine($"{n1} 이 {n2} 보다 크다 ");
            } else if (n2 > n3)
            {
                Console.WriteLine($"{n1} 은 {n2} 보다 작고, {n2} 가 {n3} 보다 크다");
            } else if (n3 > n4)
            {
                Console.WriteLine($"{n1} 은 {n2} 보다 작고, {n2} 도 {n3} 보다 작고, {n3} 는 {n4} 보다 크다");
            } else
            {
                Console.WriteLine($"{n1} 은 {n2} 보다 작고, {n2} 도 {n3} 보다 작고, {n3} 는 {n4} 보다 작다");
            }

        }
    }
}
