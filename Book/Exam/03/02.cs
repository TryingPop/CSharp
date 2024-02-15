using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.21
 * 내용 :  연습문제
 */

namespace Exam._03
{
    class King
    {
        private string name;
        private int year;

        public King(int year) : this("정조")
            {
                this.year = year;
            }

        public King(string name) // : this(name, 0) 초기값이 0이라 안해도 괜찮다
        {
            this.name = name;
        }

        public King(string name, int year) 
        {
            this.year = year;
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine("================");
            Console.WriteLine("name : {0}", this.name);
            Console.WriteLine("year : {0}", this.year);
            Console.WriteLine("----------------");
        }
    }
    internal class _03_02
    {
        static void Main2(string[] args)
        {
            King k1 = new King("태조", 1392);
            King k2 = new King("세종");
            King k3 = new King(1776);

            
        }
    }
}
