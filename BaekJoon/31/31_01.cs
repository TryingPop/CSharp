using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 12. 20
이름 : 배성훈
내용 : 문자열 폭발
    문제번호 : 9935번

    문자열 검색 알고리즘

    현재 오!답! 이다!

*/

namespace BaekJoon._31
{
     internal class _31_01
     {

        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            char[] str = sr.ReadLine().ToCharArray();

            char[] bomb = sr.ReadLine().ToCharArray();

            sr.Close();

            Stack<char> stack = new Stack<char>(bomb.Length);
            Queue<char> temp = new Queue<char>(bomb.Length);

            char chk = bomb[^1];
            for (int i = 0; i < str.Length; i++)
            {

                char c = str[i];
                stack.Push(c);

                bool boom = false;

                
                while (stack.Count != 0
                    && stack.Peek() == chk)
                {

                    for (int j = bomb.Length - 1; j >= 0; j--)
                    {

                        char top = stack.Pop();
                        temp.Enqueue(top);
                        if (top != bomb[j]) break;

                        if (j == 0) boom = true;
                        if (stack.Count == 0) break;
                    }

                    if (boom)
                    {

                        temp.Clear();
                    }
                    else
                    {

                        while (temp.Count > 0)
                        {

                            stack.Push(temp.Dequeue());
                        }
                    }
                }
            }
            
            if (stack.Count != 0)
            {
                str = new char[stack.Count];

                for (int i = str.Length - 1; i >= 0; i--)
                {

                    str[i] = stack.Pop();
                }

                Console.WriteLine(string.Concat(str));
            }
            else
            {

                Console.WriteLine("FRULA");
            }
        }

#if wrong
        static void Main1(string[] args)
        {


            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            // 일단 읽는
            string str = sr.ReadLine();

            char[] bomb = sr.ReadLine().ToCharArray();

            sr.Close();

            // 접두사와 접미사 같은 부분 찾기
            int[] jump = new int[bomb.Length];

            SetJumps(jump, bomb);


            int result = ChkString(str, bomb, jump);
            Console.WriteLine(result);

        }

        static void SetJumps(int[] _jump, char[] _chks)
        {

            int matching = 0;

            // 해당 자리 까지 맞는 경우 점프?
            for (int i = 1; i < _chks.Length; i++)
            {

                if (_chks[matching] == _chks[i])
                {

                    matching++;
                    _jump[i] = matching;
                }
                else
                {

                    matching = 0;
                }
            }
        }

        static int ChkString(string _str, char[] _bomb, int[] _jump)
        {

            int len = _str.Length;
            int dest = _bomb.Length;

            int matching = 0;
            int result = -1;
            for (int i = 0; i < len; i++)
            {

                if (_bomb[matching] == _str[i])
                {

                    if (matching == 0) result = i;
                    matching++;

                    if (matching >= dest) return result;
                }
                else if (matching != 0)
                {

                    matching = _jump[matching];
                }
            }

            return -1;
        }

#endif
    }
}
