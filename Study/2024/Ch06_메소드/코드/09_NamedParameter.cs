using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 30
이름 : 배성훈
내용 : 명명된 인수
    교재 p 208 ~ 210

    메소드를 호출할 때 매개변수 목록 중 
    어느 매개변수에 데이터를 할당할지 지정하는 것은 순서다

    대개의 경우 순서에 근거해서 매개변수에 인수를 할당하는 스타일을 사용하지만,
    C#은 명명된 인수(Named Argument)라는 기능을 지원한다

    메소드를 호출할 때 인수의 이름에 근거해서 데이터를 할당할 수 있는 기능이다

    인수의 이름 뒤에 콜론(:)을 붙이고 뒤에 할당할 데이터를 넣어주면 된다
    코드를 작성해놓고 나면 코드가 훨씬 읽기 좋아진다
*/

namespace Study._2024.Ch06_메소드.코드
{
    internal class _09_NamedParameter
    {

        static void PrintProfile(string name, string phone)
        {

            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }

        static void Main9(string[] args)
        {

            PrintProfile(name: "박찬호", phone: "010-123-1234");
            PrintProfile(phone: "010-987-9876", name: "박지성");
            PrintProfile("박세리", "010-222-2222");
            PrintProfile("박상현", phone: "010-567-5678");
        }
    }
}
