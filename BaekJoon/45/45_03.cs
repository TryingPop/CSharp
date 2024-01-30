using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 1. 30
이름 : 배성훈
내용 : 축구 전술
    문제번호 : 3977번

    예시를 직접 그래프를 그리고 확인해보니 이해했다
    해당 문제에서 찾아야할 것은 다른 모든 SCC로 갈 수 있는 SCC를 찾는 것이다

    현재 8%에서 인덱스 에러 뜬다!
*/

namespace BaekJoon._45
{
    internal class _45_03
    {

        static void Main(string[] args)
        {

            int MAX = 100_000;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int test = int.Parse(sr.ReadLine());

            // 0번부터 시작
            List<int>[] lines = new List<int>[MAX];
            List<int>[] topoLines = new List<int>[MAX]; 
            
            // 타잔으로 찾아간다!
            // 확장하는 연산은 안하게 가질 수 있는 최대 사이즈로 잡는다!
            Stack<int> s = new Stack<int>(MAX);
            
            int[] groups = new int[MAX];
            int[] id = new int[MAX];
            int[] degree = new int[MAX];

            for (int t = 0; t < test; t++)
            {

                // 한줄 띄움
                if (t != 0) 
                { 
                    
                    sr.ReadLine();
                    sw.Write('\n');
                }

                // 노드 수, 간선 수
                int[] info = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                for (int i = 0; i < info[0]; i++)
                {

                    if (lines[i] == null) lines[i] = new();
                    else lines[i].Clear();

                    if (topoLines[i] == null) topoLines[i] = new();
                    else topoLines[i].Clear();

                    // 0 번부터 넣을 생각이다!
                    id[i] = -1;
                    groups[i] = -1;

                    degree[i] = 0;
                }

                for (int i = 0; i < info[1]; i++)
                {

                    int[] temp = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                    lines[temp[0]].Add(temp[1]);
                }

                // 이제 탐색!
                int curId = -1;
                int groupId = -1;
                for (int i = 0; i < info[0]; i++)
                {

                    DFS(lines, topoLines, id, groups, i, s, ref curId, ref groupId);
                }

                // 이제 degree 확인
                for (int i = 0; i <= groupId; i++)
                {

                    for (int j = 0; j < topoLines[i].Count; j++)
                    {

                        int next = topoLines[i][j];
                        degree[next]++;
                    }
                }

                int min = -1;
                bool confused = false;
                for (int i = 0; i <= groupId; i++)
                {

                    if (degree[i] == 0)
                    {
                        
                        if (min == -1) min = i;
                        else confused = true;
                    }
                }

                if (confused)
                {

                    sw.Write("Confused\n");
                    continue;
                }
                
                for (int i = 0; i < info[0]; i++)
                {

                    if (groups[i] == min)
                    {

                        sw.Write(i);
                        sw.Write('\n');
                    }
                }
            }
            sr.Close();
            sw.Close();
        }

        static int DFS(List<int>[] _lines, List<int>[] _topoLines, int[] _id, int[] _group, int _cur, Stack<int> _calc, ref int _curId, ref int _groupId)
        {

            // 포문에서 걸리는 경우!
            if (_id[_cur] != -1) return -1;
            _id[_cur] = ++_curId;
            int result = _cur;
            _calc.Push(_cur);

            for (int i = 0; i < _lines[_cur].Count; i++)
            {

                int next = _lines[_cur][i];

                if (_id[next] != -1)
                {

                    if (_group[next] != -1) _topoLines[_groupId + 1].Add(_group[next]);
                    else if (_id[next] < _id[result]) result = next;
                    continue;
                }

                int chk = DFS(_lines, _topoLines, _id, _group, next, _calc, ref _curId, ref _groupId);
                if (_id[chk] < _id[result]) result = chk;
                else if (_id[chk] > _id[_cur])
                {

                    // 탐색하고나서 다른 그룹과 이어진 길로 판별
                    _topoLines[_groupId + 1].Add(_group[chk]);
                }
            }

            // SCC 발견!
            if (result == _cur)
            {

                _groupId++;
                while(_calc.Count > 0)
                {

                    int next = _calc.Pop();
                    _group[next] = _groupId;
                    if (next == _cur) break;
                }
            }

            return result;
        }
    }
}
