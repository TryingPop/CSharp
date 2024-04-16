using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 4. 16
이름 : 배성훈
내용 : 축사 배정
    문제번호 : 2188번

    이분매칭 문제다
    아직 이분 매칭에 익숙치 않아 풀어본 3 문제 중 1개다

    아이디어는 546과 같지만 다시 적어본다
    먼저 해당 노드에 대해 갈 수 있는 노드를 찾는다
    찾은 경우 다음으로 넘어간다

    반면 갈려고하는 곳에 이미 다른 노드가 먼저 도착했다면
    먼저 도착했던 노드보고 다른 길로 가라고 시도한다
    그리고 다른 길로 갈 수 있다면 다른 길로 보내고 해당 노드의 탐색을 끝낸다
    반면 보낼 수 없다면 다른 길을 탐색하고 앞을 반복한다
    모든 경우를 했음에도 갈 수 없다면 해당 노드는 못잇는다고 결론 짓고 종료한다
*/

namespace BaekJoon.etc
{
    internal class etc_0547
    {

        static void Main547(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int n = ReadInt();
            int m = ReadInt();

            int[][] line = new int[n + 1][];
            bool[] visit = new bool[m + 1];
            int[] match = new int[m + 1];

            int ret = 0;
            Solve();

            Console.WriteLine(ret);
            sr.Close();

            void Solve()
            {

                for (int i = 1; i <= n; i++)
                {

                    int len = ReadInt();
                    line[i] = new int[len];
                    for (int j = 0; j < len; j++)
                    {

                        line[i][j] = ReadInt();
                    }
                }

                for (int i = 1; i <= n; i++)
                {

                    Array.Fill(visit, false);
                    if (DFS(i)) ret++;
                }
            }

            bool DFS(int _n)
            {

                for (int i = 0; i < line[_n].Length; i++)
                {

                    int dst = line[_n][i];
                    if (visit[dst]) continue;
                    visit[dst] = true;

                    if (match[dst] == 0 || DFS(match[dst]))
                    {

                        match[dst] = _n;
                        return true;
                    }
                }

                return false;
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
#if other
using System;
using System.Collections.Generic;

public class Program
{
    static List<int>[] adjacency;
    static bool[] visit;
    static int[] match;
    static void Main()
    {
        string[] nm = Console.ReadLine().Split(' ');
        int n = int.Parse(nm[0]), m = int.Parse(nm[1]);
        adjacency = new List<int>[n + 1];
        for (int i = 1; i <= n; i++)
        {
            adjacency[i] = new();
        }
        for (int i = 1; i <= n; i++)
        {
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for (int j = 1; j <= array[0]; j++)
            {
                adjacency[i].Add(array[j]);
            }
        }
        visit = new bool[n + 1];
        match = new int[m + 1];
        int answer = 0;
        for (int i = 1; i <= n; i++)
        {
            if (DFS(i))
                answer++;
            Array.Fill(visit, false);
        }
        Console.Write(answer);
    }
    static bool DFS(int cur)
    {
        if (visit[cur])
            return false;
        visit[cur] = true;
        foreach (int next in adjacency[cur])
        {
            if (match[next] == 0 || DFS(match[next]))
            {
                match[next] = cur;
                return true;
            }
        }
        return false;
    }
}
#elif other2
using static IO;
public class IO{
public static IO Cin=new();
public static StreamReader reader=new(Console.OpenStandardInput());
public static StreamWriter writer=new(Console.OpenStandardOutput());
public static implicit operator string(IO _)=>reader.ReadLine();
public static implicit operator int(IO _)=>int.Parse(reader.ReadLine());
public static implicit operator string[](IO _)=>reader.ReadLine().Split();
public static implicit operator int[](IO _)=>Array.ConvertAll(reader.ReadLine().Split(),int.Parse);
public static implicit operator (int,int)(IO _){int[] a=Cin;return(a[0],a[1]);}
public static implicit operator (int,int,int)(IO _){int[] a=Cin;return(a[0],a[1],a[2]);}
public void Deconstruct(out int a,out int b){(int,int) r=Cin;(a,b)=r;}
public void Deconstruct(out int a,out int b,out int c){(int,int,int) r=Cin;(a,b,c)=r;}
public static object? Cout{set{writer.Write(value);}}
public static object? Coutln{set{writer.WriteLine(value);}}
public static void Main() {Program.Coding();writer.Flush();}
}
class Program {
    record LineInfo(int dot,int limit);
    public static void Coding() {
        (int cow_count,int barn) = Cin;
        int[][] cows = new int[cow_count][];
        for(int i=0;i<cow_count;i++) {
            int[] input = Cin;
            cows[i] = new int[input[0]];
            for(int x=0;x<input[0];x++) {
                cows[i][x] = input[x+1]-1;
            }
        }
        int?[] book = new int?[barn];
        bool[] visited;
        bool dfs(int me,int exclude) {
            if (visited[me]) return false;
            visited[me]=true;
            foreach(var place in cows[me]) {
                if (place == exclude) continue;
                if (book[place] is int other) {
                    if (dfs(other,place)) {
                        book[place] = me;
                        return true;
                    }
                    //양보 안되면 다른 장소 찾아보기.
                } else {
                    book[place] = me;
                    return true;
                }
            }
            return false;
        }

        for(int x=0;x<cow_count;x++) {
            visited = new bool[cow_count];
            dfs(x,-1);
        }

        Cout = book.Count(x => x is not null);
    }
}
#endif
}
