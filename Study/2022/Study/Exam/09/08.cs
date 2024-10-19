
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.08.04
 * 내용 : 피보나치 연습문제
 */

namespace Exam._09
{
    internal class _09_08
    {
        static void Main8(string[] args)
        {
            Console.Write("생일 입력(yyyy/mm/dd) : ");
            string birth = Console.ReadLine();
            string[] bArr = birth.Split("/");

            int bYear = int.Parse(bArr[0]);
            int bMonth = int.Parse(bArr[1]);
            int bDay = int.Parse(bArr[2]);

            int tYear = DateTime.Today.Year;
            int tMonth = DateTime.Today.Month;
            int tDay = DateTime.Today.Day;

            int totalDays = 0;

            totalDays += DayOfYear(tYear, tMonth, tDay);

            int yearDays = IsLeapYear(bYear) ? 366 : 365;
            totalDays += yearDays - DayOfYear(bYear, bMonth, bDay);

            for (int year = bYear + 1; year < tYear; year++)
            {
                if (IsLeapYear(year))
                {
                    totalDays += 366;
                }
                else
                {
                    totalDays += 365;
                }
            }
            Console.WriteLine("태어난 날부터 오늘까지 일수 : {0}", totalDays);
        }


        public static int[] days = { 0, 31, 69, 90, 120, 151, 181, 212, 243, 273, 304, 334 };
        public static int DayOfYear(int year, int month, int day)
        {
            return days[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);
        }

        public static bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }
    }
}
