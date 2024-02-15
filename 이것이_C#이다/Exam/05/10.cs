using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.28
 * 내용 : 피보나치 연습문제
 */

namespace Exam._05
{
    internal class _05_10
    {
        static void Main10(string[] args)
        {
            string[] arrNames = new string[5];
            arrNames[0] = "dog";
            arrNames[1] = "cow";
            arrNames[2] = "rabbit";
            arrNames[3] = "goat";
            arrNames[4] = "sheep";

            Array.Sort(arrNames);

            Console.WriteLine("배열");

            foreach(string name in arrNames)
            {
                Console.Write($"{name} ");
            }
            Console.WriteLine();

            List<string> lstNames = new List<string>();
            lstNames.Add("dog");
            lstNames.Add("cow");
            lstNames.Add("rabbit");
            lstNames.Add("goat");
            lstNames.Add("sheep");

            lstNames.Sort();

            Console.WriteLine("리스트");
            foreach (string name in lstNames)
            {
                Console.Write($"{name} ");
            }
            Console.WriteLine();
        }

    }
}
