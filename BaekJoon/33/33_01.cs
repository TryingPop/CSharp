using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 12. 30
이름 : 배성훈
내용 : 최단경로
    문제번호 : 1753번

    다익스트라 알고리즘

    현재 중복 방문해서 시간 초과 뜬다?
    그냥 다익스트라를 할 경우 O(N^2)이 나온다고 한다

    찾아보니 우선순위 큐 로 해야 가능하다고 한다
    아이디어를 찾아보니 순서를 정할 때 작은 가중치(= 거리) 순서로 큐에 넣어 계산

    ... 큐로 했는데 메모리 초과로 실패했다.
    아마도 안에 있는걸 제거 해야할듯 싶다
*/

namespace BaekJoon._33
{
    internal class _33_01
    {

        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int[] info = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int start = int.Parse(sr.ReadLine());

            List<int[]>[] root = new List<int[]>[info[1]];
            for (int i = 0; i < info[1]; i++)
            {

                string[] temp = sr.ReadLine().Split(' ');

                int idx = int.Parse(temp[0]);
                int[] infos = new int[2] { int.Parse(temp[1]), int.Parse(temp[2]) };

                root[idx] = root[idx] ?? new();
                root[idx].Add(infos);
            }
            sr.Close();


            StringBuilder sb = new StringBuilder();

            BFS(root, info, start, sb);

            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            sw.Write(sb);
            sw.Close();
        }

        /// <summary>
        /// 알고리즘 용이므로 불필요한 메모리 확장 연산은 안한다
        /// 만약 한다면 Enqueue에서 확인해야한다
        /// </summary>
        public class MyQueue
        {

            int _count;
            (int dst, int dis)[] arr;

            public MyQueue(int _size)
            {

                arr = new (int dst, int dis)[_size];
                
                _count = 0;
            }

            public int Count => _count;

            public void Enqueue((int dst, int dis) _add)
            {

                // idx 체크.. 커질 수 있네;
                
                int idx = _count++;
                if (arr.Length <= _count)
                {

                    // 사이즈 업! 배로한다!
                    (int dst, int dis)[] newArr = new (int dst, int dis)[_count * 2];

                    Array.Copy(arr, 0, newArr, 0, _count);
                    arr = newArr;
                }
                arr[idx] = _add;
                ChkUp(idx);
            }

            public (int dst, int dis) Dequeue()
            {

                var result = arr[0];
                arr[0] = (0, 0);

                ChkDown(0);
                return result;
            }

            private void ChkUp(int idx)
            {

                int parent = (idx - 1) / 2;
                int child = idx;

                while(parent >= 0)
                {

                    if (arr[parent].dis > arr[child].dis)
                    {

                        Swap(parent, child);
                        child = parent;
                        parent = (child - 1) / 2;
                    }
                    else break;
                }
            }

            private void ChkDown(int idx)
            {

                int cur = idx;

                while(true)
                {

                    int left = cur * 2 + 1;
                    int right = (cur + 1) * 2;

                    // 양쪽 존재 X
                    if (left >= _count) break;

                    if (right >= _count)
                    {

                        // 오른쪽 존재 X
                        Swap(cur, left);
                        cur = left;
                    }
                    else
                    {

                        // 양쪽 존재
                        if (arr[left].dis > arr[right].dis)
                        {

                            Swap(cur, right);
                            cur = right;
                        }
                        else
                        {

                            Swap(cur, left);
                            cur = left;
                        }
                    }
                }

                // 마지막과 교체
                Swap(cur, --_count);

                if (cur < _count) ChkUp(cur);
            }

            private void Swap(int _idx1, int _idx2)
            {

                var temp = arr[_idx1];
                arr[_idx1] = arr[_idx2];
                arr[_idx2] = temp;
            }
        }

        static void BFS(List<int[]>[] _root, int[] _info, int _start, StringBuilder _result)
        {

            // 정점의 개수
            int[] weights = new int[_info[0] + 1];
            // 방문 정보
            bool[] visit = new bool[_info[0] + 1];

            // Queue<int> queue = new Queue<int>();
            MyQueue queue = new MyQueue(_info[1]);

            queue.Enqueue((_start, 0));
            visit[_start] = true;

            while(queue.Count > 0)
            {

                var node = queue.Dequeue();
                int curDst = node.dst;
                int curWeight = node.dis;

                if (_root[curDst] == null) continue;

                for (int i = 0; i < _root[curDst].Count; i++)
                {

                    int dest = _root[curDst][i][0];
                    int weight = _root[curDst][i][1];

                    if (visit[dest] && weights[dest] <= curWeight + weight) continue;
                    visit[dest] = true;
                    weights[dest] = curWeight + weight;
                    queue.Enqueue((dest, weights[dest]));
                }
            }

            for (int i = 1; i < _info[0] + 1; i++)
            {

                if (visit[i]) _result.Append(weights[i].ToString());
                else _result.Append("INF");

                _result.Append('\n');
            }
        }
    }
}
