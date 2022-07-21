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
    class Rent
    {
        public void Payment()
        {
            Console.WriteLine("임대료를 받습니다.");
        }
    }

    class Landlord : Rent
    {
        public void GetMoney()
        {
            Console.WriteLine("건물주 입니다.");
            base.Payment();
        }
    }

    internal class _03_06
    {
        static void Main6(string[] args)
        {
            Landlord master = new Landlord();
            master.GetMoney();
        }
    }
}
