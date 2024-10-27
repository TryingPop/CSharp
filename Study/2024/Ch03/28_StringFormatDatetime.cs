using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 문자열 서식 맞추기 (Format - 날짜 및 시간 서식화)
    교재 p 105 ~ 109

    서식 지정자
    y : 연도
    M : 월
    d : 일
    h : 시 (1 ~ 12)
    H : 시 (1 ~ 23)
    m : 분
    s : 초
    tt : 오전/오후
    ddd : 요일


    CultureInfo는 문화권 정보를 나타내는데
    요일을 한국에서는 월화수목금으로 표현하고
    영어권에는 Monday, ..., Sunday로 표현하니 그들의 언어에 맞게 바꿔야한다
    이를 해결해주는게 CultureInfo 클래스다
*/

using static System.Console;
using System.Globalization;

namespace Study._2024.Ch03
{
    internal class _28_StringFormatDatetime
    {

        static void Main28(string[] args)
        {

            DateTime dt = new DateTime(2018, 11, 3, 23, 18, 22);

            // 12시간 형식: 2018-11-03 오후 11:18:22 (토)
            // 24시간 형식: 2018-11-03 23:18:22 (토요일)
            WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            WriteLine("24시간 형식: {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

            // 2018-11-03 오후 11:18:22 (토)
            // 2018-11-03 23:18:22(토요일)
            // 2018-11-03 오후 11:18:22
            CultureInfo ciKo = new CultureInfo("ko-KR");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)"), ciKo);
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)"), ciKo);
            WriteLine(dt.ToString(ciKo));

            // 2018-11-03 오후 11:18:22 (토)
            // 2018-11-03 23:18:22(토요일)
            // 11/3/2018 11:18:22 PM
            CultureInfo ciEn = new CultureInfo("en-US");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)"), ciEn);
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)"), ciEn);
            WriteLine(dt.ToString(ciEn));
        }
    }
}
