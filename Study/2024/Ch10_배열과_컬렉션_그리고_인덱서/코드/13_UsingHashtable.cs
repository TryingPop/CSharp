using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : Hashtable
    교재 p 387 ~ 389

    찾아보니 2개의 값으로 해싱해 충돌을 방지하려고 한다.
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{

    using static System.Console;

    internal class _13_UsingHashtable
    {

        static void Main13(string[] args)
        {

            Hashtable ht = new Hashtable();
            ht["하나"] = "one";
            ht["둘"] = "two";
            ht["셋"] = "three";
            ht["넷"] = "four";
            ht["다섯"] = "five";
                                        
            WriteLine(ht["하나"]);    // one
            WriteLine(ht["둘"]);      // two
            WriteLine(ht["셋"]);      // three
            WriteLine(ht["넷"]);      // four
            WriteLine(ht["다섯"]);    // five
        }
    }
}
