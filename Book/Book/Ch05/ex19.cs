using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 5-19
 * 
 * 모델 클래스와 List 클래스
 */

namespace Book.Ch05
{
    internal class ex19
    {
        class Student
        {
            public string name;
            public int grade;
        }

        static void Main19(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student(){ name = "윤인성", grade = 1});
            list.Add(new Student(){ name = "연하진", grade = 2});
            list.Add(new Student(){ name = "윤아린", grade = 3});
            list.Add(new Student(){ name = "윤명월", grade = 4});
            list.Add(new Student(){ name = "구지연", grade = 1});
            list.Add(new Student(){ name = "김연화", grade = 2});

            // Student 자리에 object로 하면 object에는 name 속성이 없다며 오류
            // 클래스 명 혹은 var를 적어줘야한다
            foreach (Student item in list)
            {
                Console.WriteLine("{0} : {1}", item.name, item.grade);
            }
        }
    }
}
