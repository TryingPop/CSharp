using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 8
이름 : 배성훈
내용 : 연습문제 2
    교재 p 483

    출력 결과가 다음과 같이 나오도록 다음 코드에 이벤트 처리기를 추가하세요.

    출력 결과
        축하합니다! 30번째 고객 이벤트에 당첨되셨습니다.

    코드
        using System;

        delegate void MyDelegate(int a);

        class Market
        {

            public event MyDelegate CustomerEvent;

            public void BuySomething(int CustomerNo)
            {

                if (CustomerNo == 30)
                    Customerevent(CustomerNo);
            }
        }

        static void Main(string[] args)
        {

            Market market = new Market();

            market.CustomerEvent += new MyDelegate(
                // 이벤트 처리기를 구현하세요.
                );

            for (int customerNo = 0; customerNo < 100; customerNo += 10)
                market.BuySomething(customerNo);        
        }
*/

namespace Study._2024.Ch13_대리자와_이벤트.코드
{
    internal class _08_ex_02
    {

        delegate void MyDelegate(int a);

        class Market
        {

            public event MyDelegate CustomerEvent;

            public void BuySomething(int CustomerNo)
            {

                if (CustomerNo == 30)
                    CustomerEvent(CustomerNo);
            }
        }

        static void Main8(string[] args)
        {

            Market market = new Market();
            market.CustomerEvent += new MyDelegate(
                delegate (int a) { Console.WriteLine($"축하합니다! {a}번째 고객 이벤트에 당첨되셨습니다."); }
                );

            for (int customerNo = 0; customerNo < 100; customerNo += 10)
                market.BuySomething(customerNo);
        }
    }
}
