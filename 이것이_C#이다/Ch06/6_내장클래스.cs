using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.20
 * 내용 : 자주 사용하는 내장 클래스 실습하기 교재
 */

namespace Ch06
{
    internal class _6_내장클래스
    {
        static void Main6(string[] args)
        {
            // Math 클래스
            // 생성자가 private 이므로 생성 안한다
            // Math math = new Math();

            // 바로 참조 가능하므로 static
            Console.WriteLine("PI : {0}", Math.PI);
            Console.WriteLine("9의 제곱근 : {0}", Math.Sqrt(9));
            Console.WriteLine("16의 제곱근 : {0}", Math.Sqrt(16));
            Console.WriteLine("-5의 절대값 : {0}", Math.Abs(-5));
            Console.WriteLine();
            Console.WriteLine("1.2 올림값 : {0}", Math.Ceiling(1.2));
            Console.WriteLine("1.2 내림값 : {0}", Math.Floor(1.2));
            Console.WriteLine("1.2 반올림 : {0}", Math.Round(1.2));
            Console.WriteLine();
            Console.WriteLine("1.8 올림값 : {0}", Math.Ceiling(1.8));
            Console.WriteLine("1.8 내림값 : {0}", Math.Floor(1.8));
            Console.WriteLine("1.8 반올림 : {0}", Math.Round(1.8));


            // random 클래스
            Random rd = new Random();
            // 0 ~ 1 사이의 임의의 실수
            double num1 = rd.NextDouble();
            Console.WriteLine("num1 : {0}", num1);
            Console.WriteLine();

            // 0 ~ 10 사이의 임의의 실수
            double num2 = num1 * 10;
            Console.WriteLine("num2 : {0}", num2);
            Console.WriteLine();

            // 1 ~ 10 사이의 임의의 정수
            double num3 = Math.Ceiling(num2);
            Console.WriteLine("num3 : {0}", num3);
            Console.WriteLine();

            // 1 ~ 10 사이의 임의의 정수
            int num4 = rd.Next(1, 11);
            Console.WriteLine("num4 : {0}", num4);
            Console.WriteLine();

            // 0 ~ int의 최대값 사이의 임의의 정수
            int num5 = rd.Next();
            Console.WriteLine("num5 : {0}", num5);
            Console.WriteLine();

            // 0 ~ 10 사이의 임의의 정수
            int num6 = rd.Next(11);
            Console.WriteLine("num6 : {0}", num6);
            Console.WriteLine();


            // DateTime 클래스
            
            // C# 에서는 읽기 전용 구조체
            DateTime _dt = new DateTime();
            // 다른 언어에서는 싱글톤
            DateTime dt = DateTime.Now;

            Console.WriteLine("현재 : {0}", dt);
            Console.WriteLine("현재 년도 : {0}", dt.Year);
            Console.WriteLine("현재 월 : {0}", dt.Month);
            Console.WriteLine("현재 일 : {0}", dt.Day);
            Console.WriteLine("현재 시 : {0}", dt.Hour);
            Console.WriteLine("현재 분 : {0}", dt.Minute);
            Console.WriteLine("현재 초 : {0}", dt.Second);
            Console.WriteLine();

            // 문자열 Format을 이용해 날짜 출력
            string strdt1 = dt.ToString("yyyy-MM-dd");
            Console.WriteLine(strdt1);
            Console.WriteLine();
            
            // ddd >> 요일  ex : 목, 월 etc
            // dddd >> 마찬가지로 요일 ex : 화요일 일요일
            string strdt2 = dt.ToString("yy-MM-dd hh:mm:ss");
            Console.WriteLine(strdt2);
            Console.WriteLine();

        }
    }
}
