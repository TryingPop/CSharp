using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

/*
날짜 : 2023. 12. 27
이름 : 배성훈
내용 : 숨박꼭질
    문제번호 : 1697번

    현재 오답코드이다
    이진 트리 이동을 고려해서 코드를 작성했다
    만약 * 2 이동과 - 1이동인 경우로 잘못해석했다

    이 경우
    먼저 층계를 찾고
    위에층에서 이동하며 최소한으로 맞추고 있다;
*/

namespace BaekJoon._32
{
    internal class _32_10
    {

        static void Main10(string[] args)
        {

            int[] pos = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            BFS(pos, out int result);

            Console.WriteLine();
        }

        static void BFS(int[] _pos, out int _result)
        {

            if (_pos[0] - _pos[1] >= 0)
            {

                _result = _pos[0] - _pos[1];
                return;
            }

            _result = 0;

            if (_pos[0] == 0) 
            { 
                
                _pos[0]++;
                _result++;
            }

            // 이제 연산!
            int floor = 1;


            while (true)
            {

                if (_pos[0] - floor < floor)
                {

                    break;
                }

                floor *= 2;
            }

            Stack<int> destParents = new Stack<int>();
            int chk = _pos[1];
            while (true)
            {

                int calc = chk - floor;
                destParents.Push(chk);

                if (calc >= 0 && calc < floor)
                {

                    break;
                }

                chk /= 2;
            }

            int cur = _pos[0];
            while(destParents.Count > 0)
            {

                int top = destParents.Pop();
                int calc = cur - top;
                if (calc < 0) calc = -calc;

                _result += calc;
                cur = top;

                if (destParents.Count > 0)
                {

                    cur *= 2;
                    _result++;
                }
            }
        }

    }
}
