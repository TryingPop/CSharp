using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 문자열 변형하기
    교재 p96 ~ 99

    ToLower : 현재 문자열의 모든 대문자를 소문자로 바꾼 새 문자열을 반환
    ToUpper : 현재 문자열의 모든 소문자를 대문자로 바꾼 새 문자열을 반환
    Insert : 현재 문자열의 지정된 위치에 지정된 문자열이 삽입된 새 문자열을 반환
    Remove : 현재 문자열의 지정된 위치로부터 지정된 수만큼 문자가 삭제된 새 문자열을 반환
    Trim : 현재 문자열의 앞 뒤 공백을 삭제한 새 문자열을 반환
    TrimStart : 앞에 있는 공백을 삭제한 새 문자열을 반환
    TrimEnd : 뒤에 있는 공백을 삭제한 새 문자열을 반환
*/

using static System.Console;

namespace Study._2024.Ch03
{
    internal class _25_StringModify
    {

        static void Main25(string[] args)
        {

            WriteLine("ToLower(): '{0}'", "ABC".ToLower());
            WriteLine("ToUpper(): '{0}'", "abc".ToUpper());

            WriteLine("Insert(): '{0}'", "Happy Friday!".Insert(5, " Sunny"));      // Happy Sunny Friday
            WriteLine("Remove(): '{0}'", "I Don't Love You.".Remove(2, 6));         // I Love You

            WriteLine("Trim(): '{0}'", " No Spaces ".Trim());
            WriteLine("TrimStart(): '{0}'", " No Spaces ".TrimStart());
            WriteLine("TrimEnd(): '{0}'", " No Spaces ".TrimEnd());
        }
    }
}
