using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.29
 * 내용 : 피보나치 연습문제
 */

namespace Exam._06
{
    internal class _06_01
    {
        static void Main1(string[] args)
        {
            Dictionary<string, string> colorDic = new Dictionary<string, string>();

            colorDic.Add("red", "빨간색");
            colorDic.Add("green", "초록색");
            colorDic.Add("blue", "파란색");

            try
            {
                colorDic.Add("red", "빨강");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine($"yellow : {colorDic["yellow"]}");
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (var v in colorDic)
            {
                Console.WriteLine($"colorTable[{v.Key}] : {v.Value}");
            }

            Console.WriteLine("프로그램 종료...");
        }
    }
}
