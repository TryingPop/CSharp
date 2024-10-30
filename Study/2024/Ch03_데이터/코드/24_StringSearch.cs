using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 문자열 안에서 찾기
    교재 p94 ~ 96

    IndexOf 찾고자 하는 문자, 문자열의 시작위치를 찾는다
    LastIndexOf 찾고자 하는 문자, 문자열의 시작위치를 뒤에서부터 찾는다
    StartsWith : 현재 문자열이 지정된 문자열로 시작하는지 판별
    EndsWith : 현재 문자열이 지정된 문자열로 끝나는지를 판별
    Contains : 현재 문자열이 지정된 문자열을 포함하는지를 판별
*/

using static System.Console;

namespace Study._2024.Ch03
{
    internal class _24_StringSearch
    {

        static void Main24(string[] args)
        {

            string greeting = "Good Morning";

            WriteLine(greeting);
            WriteLine();

            // IndexOf()
            WriteLine("IndexOf 'Good': {0}", greeting.IndexOf("Good"));     // 0
            WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));          // 1


            // LastIndexOf()
            WriteLine("LastIndexOf 'Good': {0}", greeting.LastIndexOf("Good")); // 0
            WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf('o'));      // 6

            // StartsWith()
            WriteLine("StartsWith 'Good': {0}", greeting.StartsWith("Good"));   // True
            WriteLine("StartsWith 'Morning': {0}", greeting.StartsWith("Morning")); // False

            // EndsWith()
            WriteLine("EndsWith 'Good': {0}", greeting.EndsWith("Good"));       // False
            WriteLine("EndsWith 'Morning': {0}", greeting.EndsWith("Morning")); // True

            // Contains()
            WriteLine("Contains 'Evening': {0}", greeting.Contains("Evening")); // False
            WriteLine("Contains 'Morning': {0}", greeting.Contains("Morning")); // True

            // Replace()
            WriteLine("Replaced 'Morning' with 'Evening': {0}",
                greeting.Replace("Morning", "Evening"));                        // Good Evening

        }
    }
}
