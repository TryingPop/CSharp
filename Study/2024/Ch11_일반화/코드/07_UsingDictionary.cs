using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : Dictionary<TKey, TValue>
    교재 p 423 ~ 424

    앞의 Hashtable과 같다.
*/

namespace Study._2024.Ch11_일반화.코드
{
    internal class _07_UsingDictionary
    {

        static void Main7(string[] args)
        {

            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic["하나"] = "one";
            dic["둘"] = "two";
            dic["셋"] = "three";
            dic["넷"] = "four";
            dic["다섯"] = "five";

            Console.WriteLine(dic["하나"]);  // one
            Console.WriteLine(dic["둘"]);    // two
            Console.WriteLine(dic["셋"]);    // three
            Console.WriteLine(dic["넷"]);    // four
            Console.WriteLine(dic["다섯"]);  // five
        }
    }
}
