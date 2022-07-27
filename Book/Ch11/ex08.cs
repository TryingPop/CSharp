

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 11-8
 * 
 * 콜백 메서드
 */

namespace Book.Ch11
{
    internal class ex08
    {
        class Student
        {
            public string Name { get; set; }
            public double Score { get; set; }

            public Student(string name, double score)
            {
                this.Name = name;
                this.Score = score;
            }

            public override string ToString()
            {
                return $"{this.Name} : {this.Score}";
            }
        }

        class Students
        {
            private List<Student> listOfStudents = new List<Student>();

            public delegate void PrintProcess(Student list);

            public void Add(Student student)
            {
                this.listOfStudents.Add(student);
            }

            public void Print()
            {
                this.Print((Student student) =>
                {
                    Console.WriteLine(student);
                });
            }

            public void Print(PrintProcess process)
            {
                foreach (Student item in this.listOfStudents)
                {
                    process(item);
                }
            }
        }

        static void Main8(string[] args)
        {
            Students students = new Students();
            students.Add(new Student("윤인성", 4.2));
            students.Add(new Student("연하진", 4.4));
            
            students.Print();
            students.Print((Student student) =>
            {
                Console.WriteLine();
                Console.WriteLine($"이름 : {student.Name}");
                Console.WriteLine($"학점 : {student.Score}");
            });
        }

        
    }
}
