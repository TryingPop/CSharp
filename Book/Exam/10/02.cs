using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.08.05
 * 내용 : 피보나치 연습문제
 */

namespace Exam._10
{
    internal class _10_02
    {
        class Person
        {
            private string name;
            private int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void TakeBus(Bus bus)
            {
                bus.Take(name);
            }

            public void TakeSubway(Subway subway)
            {
                subway.Take(name);
            }   
        }

        public class Bus
        {
            private string number;
            private int fee;

            public Bus(string number, int fee)
            {
                this.number = number;
                this.fee = fee;
            }

            public void Take(string name)
            {
                Console.WriteLine($"{name}은 {this.number}버스를 탑니다.");
                Console.WriteLine($"버스 요금은 {this.fee:C}입니다.");
            }
        }

        public class Subway
        {
            private string line;
            private int fee;

            public Subway(string line, int fee)
            {
                this.line = line;
                this.fee = fee;
            }

            public void Take(string name)
            {
                Console.WriteLine($"{name}은 {line}호선 지하철을 탑니다.");
                Console.WriteLine($"지하철 요금은 {this.fee:C}입니다.");
            }
        }

        static void Main2(string[] args)
        {
            Person kim = new Person("김유신", 24);
            Person lee = new Person("이순신", 34);

            Bus bus = new Bus("64", 1500);
            Subway subway = new Subway("1", 1600);

            kim.TakeBus(bus);
            lee.TakeSubway(subway);
        }

    }
}
