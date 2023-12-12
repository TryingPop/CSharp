using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 12. 11
이름 : 배성훈
내용 : 히스토그램에서 가장 큰 직사각형
    문제번호 : 6549번

    그냥 이중 포문 돌리면 O(n^2) 이라 시간초과뜬다

    여기서는 스택을 이용해 풀자!
    
    이건 추후에 해볼 방법
    세그먼트 트리 + 분할 정복으로 푼다고 한다
    세그먼트 트리는 구간합 or 값 변경 시간 복잡도가 n이 log n 으로 바뀐다 
    대신 값 변경할 때 부모노드도 변경해야 하기에 시간 복잡도 1이 log n 으로 바뀐다
*/

namespace BaekJoon._27
{
    internal class _27_09
    {

        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();

            using (StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput())))
            {

                while (true)
                {

                    int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                    if (inputs[0] == 0) break;

                    Stack<int> idxs = new Stack<int>(inputs[0]);
                    long max = 0;
                    long min = int.MaxValue;

                    for(int i = 1; i <= inputs[0]; i++)
                    {

                        if (min > inputs[i]) min = inputs[i];

                        while(idxs.Count != 0 && inputs[idxs.Peek()] > inputs[i])
                        {

                            long height = inputs[idxs.Peek()];
                            long width = i - idxs.Pop();

                            if (max < width * height)
                            {

                                max = width * height;
                            }
                        }
                        
                        idxs.Push(i);
                    }

                    while(idxs.Count != 0)
                    {

                        long height = inputs[idxs.Peek()];
                        long width = inputs[0] - idxs.Pop() + 1;


                        if (max < width * height)
                        {

                            max = width * height;
                        }
                    }

                    if (min * inputs[0] > max) max = min * inputs[0];

                    sb.AppendLine(max.ToString());
                }
            }

            using (StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput())))
            {

                sw.Write(sb);
            }
        }
    }
}
