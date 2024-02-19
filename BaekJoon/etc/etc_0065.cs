using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

/*
날짜 : 2024. 2. 20
이름 : 배성훈
내용 : 가위바위보
    문제번호 : 8896번

    구현과 시물레이션 문제다
    가위바위보 상황을 시물레이션 해서 풀었다
*/

namespace BaekJoon.etc
{
    internal class etc_0065
    {

        static void Main65(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            List<int> r = new List<int>(10);        // 묵
            List<int> s = new List<int>(10);        // 찌
            List<int> p = new List<int>(10);        // 빠

            Queue<int> q = new Queue<int>(10);      // 연산용

            Dictionary<char, bool> use = new();

            use.Add('R', false);
            use.Add('S', false);
            use.Add('P', false);

            string[] robots = new string[10];
            int test = int.Parse(sr.ReadLine());
            
            while(test-- > 0)
            {

                int len = int.Parse(sr.ReadLine());

                for (int i = 0; i < len; i++)
                {

                    robots[i] = sr.ReadLine();
                    q.Enqueue(i);
                }

                for (int i = 0; i < robots[0].Length; i++)
                {

                    while(q.Count > 0)
                    {

                        var idx = q.Dequeue();
                        char chk = robots[idx][i];

                        if (chk == 'R')
                        {

                            r.Add(idx);
                            use['R'] = true;
                        }
                        else if (chk == 'S')
                        {

                            s.Add(idx);
                            use['S'] = true;
                        }
                        else 
                        {

                            p.Add(idx); 
                            use['P'] = true;
                        }
                    }

                    if (use['R'] && use['S'] && use['P'])
                    {

                        for (int j = 0; j < r.Count; j++)
                        {

                            q.Enqueue(r[j]);
                        }
                        
                        for (int j = 0; j < s.Count; j++)
                        {

                            q.Enqueue(s[j]);
                        }

                        for (int j = 0; j < p.Count; j++)
                        {

                            q.Enqueue(p[j]);
                        }

                        r.Clear();
                        s.Clear();
                        p.Clear();
                    }
                    else if (use['R'] && use['S'])
                    {

                        for (int j = 0; j < r.Count; j++)
                        {

                            q.Enqueue(r[j]);
                        }

                        r.Clear();
                        s.Clear();
                    }
                    else if (use['S'] && use['P'])
                    {

                        for (int j = 0; j < s.Count; j++)
                        {

                            q.Enqueue(s[j]);
                        }

                        s.Clear();
                        p.Clear();
                    }
                    else if (use['P'] && use['R'])
                    {

                        for (int j = 0; j < p.Count; j++)
                        {

                            q.Enqueue(p[j]);
                        }

                        p.Clear();
                        r.Clear();
                    }
                    else if (use['R'])
                    {

                        for (int j = 0; j < r.Count; j++)
                        {

                            q.Enqueue(r[j]);
                        }

                        r.Clear();
                    }
                    else if (use['S'])
                    {

                        for (int j = 0; j < s.Count; j++)
                        {

                            q.Enqueue(s[j]);
                        }

                        s.Clear();
                    }
                    else if (use['P'])
                    {

                        for (int j = 0; j < p.Count; j++)
                        {

                            q.Enqueue(p[j]);
                        }

                        p.Clear();
                    }

                    use['R'] = false;
                    use['S'] = false;
                    use['P'] = false;

                    if (q.Count == 1) break;
                }

                if (q.Count == 1) sw.WriteLine(q.Dequeue() + 1);
                else if (q.Count > 1) 
                { 
                    
                    sw.WriteLine(0);
                    q.Clear();
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
