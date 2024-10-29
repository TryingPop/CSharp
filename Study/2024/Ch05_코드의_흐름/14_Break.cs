using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Annotations;

/*
날짜 : 2024. 10. 29
이름 : 배성훈
내용 : 점프문
    교재 p174 ~ 176

    흐름 제어문들은 흐름을 분기하거나 반복하더라도 
    흐름을 끊는 기능은 없었다

    점프문은 흐름을 끊고 프로그램의 실행 위치를 
    원하는 곳으로 단숨에 도약시킬 수 있다

        break
        continue
        goto
        return
        throw
    가 있다

    break은 중단하다는뜻이다
    현재 실행 중인 반복문이나 switch 문을 중단하고자 할 때 사용한다
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _14_Break
    {

        static void Main14(string[] args)
        {

            while(true)
            {

                Console.Write("계속할까요?(예/아니오) : ");
                string answer = Console.ReadLine();

                if (answer == "아니오")
                    break;
            }
        }
    }
}
