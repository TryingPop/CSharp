using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 4. -
이름 : 배성훈
내용 : 영어와 프랑스어 (small)
    문제번호 : 12143번

    당장은 아이디어가 안떠올라 패스다
    영어가 포함되는 경우가 있으면 해당 말의 모든 단어를 영어로 봐야한다
    마찬가지로 프랑스어로 포함되는 경우가 있으면 해당 말의 모든 단어를 프랑스어로 봐야한다

    그리고 이전의 말도 다시 확인해야한다
    그렇게 해서 중복이 최소가 되게 세팅해야한다

    그리고 처음 단어는 1000개가된다
    해시셋으로 설정해 단어 확인을... 할까싶다
    일단 시간 나면 나중에 풀어봐야겠다;
    Small, Large 두 문제를 해결하려면 먼저 말들을 그룹화해서, 엮고, dp를 써야하지 않을까 싶다

    찾아보니 최대 유량 알고리즘을 써야한다
*/

namespace BaekJoon.etc
{
    internal class etc_0513
    {

        static void Main513(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            HashSet<string> en = new HashSet<string>(500);
            HashSet<string> fr = new HashSet<string>(500);
            HashSet<string> ret = new HashSet<string>(500);

            string[][] words = new string[18][];

            int test = ReadInt();
            for (int t = 1; t <= test; t++)
            {

                int n = ReadInt();

                AddSet(sr.ReadLine().Split(), en);
                AddSet(sr.ReadLine().Split(), fr);

                int len = n - 2;
                for (int i = 0; i < len; i++)
                {

                    words[i] = sr.ReadLine().Split();

                    int frs = 0;
                    int ens = 0;
                    for (int j = 0; j < words[i].Length; j++)
                    {

                        if (en.Contains(words[i][j])) ens++;
                        if (fr.Contains(words[i][j])) frs++;
                    }


                }


                en.Clear();
                fr.Clear();
            }

            sr.Close();
            sw.Close();

            void AddSet(string[] _word, HashSet<string> _set)
            {

                for (int i = 0; i < _word.Length; i++)
                {

                    _set.Add(_word[i]);
                }
            }

            int ReadInt()
            {

                int c, ret = 0;
                while((c = sr.Read()) != -1 && c != ' ' && c != '\n')
                {

                    if (c == '\r') continue;
                    ret = ret * 10 + c - '0';
                }

                return ret;
            }
        }
    }
}
