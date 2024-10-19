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
    class Car
    {
        private string company;
        private string name;
        private int price;

        public Car(string company, string name, int price)
        {
            this.company = company;
            this.name = name;
            this.price = price;
        }

        public void Drive()
        {
            Console.WriteLine("{0} 운행 중...", this.name);
        }

        public void Show()
        {
            Drive();
            Console.WriteLine("제조사 : {0}", this.company);
            Console.WriteLine("이름 : {0}", this.name);
            Console.WriteLine("가격 : {0}", this.price);
            Console.WriteLine();
        }
    }
    internal class _03_03
    {
        static void Main3(string[] args)
        {
            Car sonata;
            Car bmw;

            sonata = new Car("현대", "소나타", 3000);
            bmw = new Car("BMW", "520d", 5000);

            sonata.Show();
            bmw.Show();
        }
    }
}
