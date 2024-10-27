using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 문자열을 숫자로, 숫자를 문자열로
    교재 p76 ~ 78

    상속 관계에 있는 클래스에 한해서 캐스팅이 가능하다
    string과 int는 상속관계가 아니므로 별도의 변환법이 필요하다
*/

namespace Study._2024.Ch03
{
    internal class _16_StringNumberConversion
    {

        static void Main16(string[] args)
        {

            int a = 123;
            string b = a.ToString();
            Console.WriteLine(b);       // 123

            float c = 3.14f;
            string d = c.ToString();
            Console.WriteLine(d);       // 3.14

            string e = "123456";
            int f = Convert.ToInt32(e);
            Console.WriteLine(f);       // 123456

            string g = "1.2345";
            float h = float.Parse(g);
            Console.WriteLine(h);       // 1.2345
        }
    }
}
