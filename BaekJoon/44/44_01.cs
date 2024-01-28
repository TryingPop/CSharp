using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 1. 28
이름 : 배성훈
내용 : 가장 가까운 공통 조상
    문제번호 : 3584번
*/

namespace BaekJoon._44
{


    internal class _44_01
    {

        static void Main1(string[] args)
        {


            int MAX = 10_000;
            int[] parent = new int[MAX + 1];
            Stack<int> calc1 = new Stack<int>(MAX);
            Stack<int> calc2 = new Stack<int>(MAX);

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int test = int.Parse(sr.ReadLine());

            for (int t = 0; t < test; t++)
            {

                int len = int.Parse(sr.ReadLine());

                calc1.Clear();
                calc2.Clear();
                for (int i = 1; i <= len; i++)
                {

                    parent[i] = 0;
                }

                for (int i = 0; i < len - 1; i++)
                {

                    int[] temp = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                    parent[temp[1]] = temp[0];
                }

                int[] info = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
                FindParent(parent, info[0], calc1);
                FindParent(parent, info[1], calc2);

                int result = -1;
                int p1 = calc1.Pop();
                int p2 = calc2.Pop();
                while(p1 == p2)
                {

                    result = p1;
                    if (calc1.Count == 0 || calc2.Count == 0) break;
                    
                    p1 = calc1.Pop();
                    p2 = calc2.Pop();
                }

                sw.WriteLine(result);
                sw.Flush();
            }

            sw.Close();
            sr.Close();
        }

        static void FindParent(int[] _parents, int _find, Stack<int> _result)
        {

            while(_find != -1)
            {

                _result.Push(_find);
                _find = _parents[_find];
            }
        }
    }
}
