using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 6. 25
이름 : 배성훈
내용 : 표준 형식 지정자
    문자열 보간에서 사용하는 표준 숫자 형식 문자열들
    
    string.Format("{0, ?}");
    string.Format("{0:?}");

    혹은
    $"{var, ?}";
    $"{var:?}";

    var.ToString(?);

    에서 ?에 해당하는 기능이다
*/

namespace Private
{
    internal class _29_FormatString
    {

        static void Main29(string[] args)
        {

            int i = 123;
            float f = 5.6f;
            string s = "가나";
            string sf;

            sf = $"||{i,5}||";

            Console.WriteLine(sf);  // ||  123||
                                    // 123 앞에 공백 2칸이 추가된다
                                    // 해당 문자의 칸을 뒤에 숫자가 되게 보정한다
                                    // 문자 배치는 오른쪽에 가게 배치한다

            sf = $"||{f,1}||";
            Console.WriteLine(sf);  // ||5.6||
                                    // 우측에 들어가는 숫자가 기존의 자리수보다 적은 경우
                                    // 일반 출력과 같다

            sf = $"||{s,-6}||";     
            Console.WriteLine(sf);  // ||가나      ||
                                    // 왼쪽부터 배치하려면 음수를 넣으면 된다
                                    // 마찬가지로 음수의 절대값이 기존 문자보다 적은경우
                                    // 일반 출력과 같다

            sf = $"{i:c2}";    
            Console.WriteLine(sf);  // \123.000
                                    // 뒤에 숫자는 소수점 자리수에 영향을 끼친다

            sf = $"{f:C0}";     
            Console.WriteLine(sf);  // \6
                                    // 반올림해서 표현하는 것을 볼 수 있다
                                    // 음수는 표현안된다

            sf = $"{f:C-1}";
            Console.WriteLine(sf);  // C-1
                                    // 음수는 사용 불가능

            sf = $"{s:C0}";
            Console.WriteLine(sf);  // 마찬가지로 문자열에서는 효력이 없다

            sf = $"{i:e0}";
            Console.WriteLine(sf);  // 1e+002
                                    // 지수 표기법

            sf = $"{i:e3}";         
            Console.WriteLine(sf);  // 1.230e+002
                                    // e?에서 ? 숫자는 e의 앞에 소수점 자리수와 연관이 있다

            sf = $"{f:f8}";         
            Console.WriteLine(sf);  // 5.59999990
                                    // 부동 소수점 표시이다 정수의 경우 숫자만큼 . 뒤로 0이 붙는다
                                    // 실수는 메모리 저장 방식에 의해 값이 변하는거 같다

            sf = $"{i:n6}";         
            Console.WriteLine(sf);  // 123.000000
                                    // f와 다른게 없어 보인다
                                    // https://learn.microsoft.com/ko-kr/dotnet/standard/base-types/standard-numeric-format-strings
                                    // 사이트 참고해서 보면 n과 f에 차이는 있어보인다

            sf = $"{i:x3}";         
            Console.WriteLine(sf);  // 07b
                                    // 16진수로 표현해준다
                                    // 0x07b의 반대 표현이라 보면 되겠다
        }
    }
}
