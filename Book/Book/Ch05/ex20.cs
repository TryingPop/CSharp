using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 5-20
 * 
 * 리스트와 모델 클래스 동시 초기화
 */

namespace Book.Ch05
{
    internal class ex20
    {
        class Student
        {
            public string name;
            public int grade;
        }

        static void Main20(string[] args)
        {
            List<Student> list = new List<Student>() 
            { 
                new Student() { name = "윤인성", grade = 1},
                new Student() { name = "연하진", grade = 2},
                new Student() { name = "윤아린", grade = 3},
                new Student() { name = "윤명월", grade = 4},
                new Student() { name = "구지연", grade = 1},
                new Student() { name = "김연화", grade = 2}
            };

            foreach (Student item in list)
            {
                Console.WriteLine("{0} : {1}", item.name, item.grade);
            }
        }
    }
}
