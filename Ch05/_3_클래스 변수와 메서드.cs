using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ch05.Sub3;

/* 날짜 : 2022.07.18
 * 내용 : 클래스 변수, 클래스 메서드 실습하기 교재 p225
 * 
 * 클래스 변수, 클래스 메서드
 *  - 클래스 변수와 클래스 메서드는 static을 선언한 변수와 메서드로 Data 영역 메모리 공간에 하나의 클래스로 관리
 *  - 클래스 이름으로 직접 참조하거나 호출한다.
 * 
 * 싱글톤(Singleton)
 *  - static을 활용한 가장 대표적인 객체 생성 방법
 *  - 싱글톤 패턴이 적용된 객체는 메모리에 하나의 인스턴스만 생성하고 공유한다.
 *  - 싱글톤 객체를 활용해서 메모리 절약과 성능 향상을 도모한다.
 */

namespace Ch05
{
    class Increment
    {
        public int num1;
        
        // Data Area에 따로 관리되는 클래스 변수
        public static int num2;

        public Increment()
        {
            this.num1++;
            Increment.num2++;

            Console.WriteLine("num1 : {0}\nnum2 : {1}", this.num1, Increment.num2);
        }

        public void Add()
        {
            this.num1++;
            Increment.num2++;

            Console.WriteLine("num1 : {0}\nnum2 : {1}", this.num1, Increment.num2);
        }

        // Data 영역에 따로 관리되는 클래스 메서드(정적 메서드)
        public static void ADD()
        {
            // 클래스 메서드(static 메서드)는 non-static 변수를 참조할 수 없다.
            Increment.num2++;

            Console.WriteLine("num2 : {0}", Increment.num2);
        }
    }

    internal class _3_클래스_변수와_메서드
    {
        // static : Data영역에 보관한다(전역변수)
        static void Main(string[] args)
        {
            // int의 초기값이 0이고 생성자쪽에서 +1씩 추가된다.
            Increment inc1 = new Increment() { };
            Increment inc2 = new Increment() { };
            Increment inc3 = new Increment() { };

            // 클래스 변수 참조
            Increment.num2 = 2;
            Console.WriteLine();

            Increment.ADD();


            Car car1 = new Car("페라리", "빨강", 0);
            car1.Show();
            Car car2 = new Car("싼타페", "검정", 0);
            car2.Show();

            // 싱글톤 객체
            Calc calc = Calc.Instance;

            int t1 = calc.Plus(1, 2);
            int t2 = calc.Minus(1, 2);
            int t3 = calc.Multi(2, 3);
            int t4 = calc.Div(4, 2);

            Console.WriteLine("t1 : {0}", t1);
            Console.WriteLine("t2 : {0}", t2);
            Console.WriteLine("t3 : {0}", t3);
            Console.WriteLine("t4 : {0}", t4);
        }       
    }
}

// 프로그램 실행 
// 데이터 영역에 Main 메서드가 올라간다(Main은 static)
// 이후 정적 메서드가 올라온다
// 그래서 아직 정의되지 않은 non static 변수는 참조를 못한다