using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 5-22
 * 
 * for 반복문으로 요소 제거
 */

namespace Book.Ch05
{
    internal class ex22
    {
        class Student
        {
            public string name;
            public int grade;
        }

        static void Main22(string[] args)
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

            // 디버깅으로 확인해보면
            // 연하진이 바로 빠져나가서
            // 윤아린이 인덱스 1번이 되어버린다
            // 반면 i는 2번으로 가서
            // 윤아린은 건너뛴다

            for (int i =0; i < list.Count; i++)
            {
                if (list[i].grade > 1)
                {
                    list.RemoveAt(i);
                }
            }

            foreach (Student item in list)
            {
                Console.WriteLine("{0} : {1}", item.name, item.grade);
            }
        }
    }
}
