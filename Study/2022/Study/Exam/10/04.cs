
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
    internal class _10_04
    {
        class Human
        {
            private string name;
            private int age;

            public Human(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            protected void Hello()
            {
                Console.WriteLine($"이름 : {this.name}");
                Console.WriteLine($"나이 : {this.age}");
            }
        }

        class Student : Human
        {
            private int studentId;

            public Student(string name, int age, int studentId):base(name, age)
            {
                this.studentId = studentId;
            }

            public void Hello()
            {
                base.Hello();
                Console.WriteLine($"학번 : {this.studentId}\n");
            }
        }

        class Worker : Human
        {
            private int workId;

            public Worker(string name, int age, int workId) : base(name, age)
            {
                this.workId = workId;
            }

            public void Hello()
            {
                base.Hello();
                Console.WriteLine($"사번 : {this.workId}\n");
            }
        }

        static void Main4(string[] args)
        {
            Student kim = new Student("김철수", 21, 20201234);
            Worker lee = new Worker("이철수", 35, 20211201);

            kim.Hello();
            lee.Hello();
        }
    }
}
