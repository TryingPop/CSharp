using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.22
 * 내용 : 피보나치 연습문제
 */

namespace Exam._04
{
    class Employee
    {
        // = "홍길동" 초기값
        public string Name { get; set; } = "홍길동";
        public string Position { get; set; } = "사원";

        public void Show()
        {
            Console.WriteLine("====================");
            Console.WriteLine("이름 : {0}", this.Name);
            Console.WriteLine("직급 : {0}", this.Position);
            Console.WriteLine("--------------------");
        }

    }
    internal class _04_03
    {

        static void Main3(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Show();

            Employee emp2 = new Employee();
            emp2.Name = "김유신";
            emp2.Position = "대리";
            emp2.Show();

            Employee emp3 = new Employee() { Name = "김춘추", Position = "과장" };
            emp3.Show();
        }

    }
}
