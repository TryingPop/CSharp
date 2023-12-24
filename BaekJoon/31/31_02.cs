using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 12. 23
이름 : 배성훈
내용 : 오큰수
    문제번호 : 17298번

    바로 뒤에 원소가 없으면 -1
    <0>. 즉 마지막 원소의 오큰수는 항상 -1

    이후 순 증가하는 경우와 순 감소하는 경우를 생각했다

    <1>. arr이 순 증가하는 경우
    즉, 모든 i에 대해 arr[i] < arr[i + 1]랑 같은 말이다
    그러므로 i번째의 오큰 수는 arr[i + 1]이 된다
    단, 마지막 항은 -1이다

    이 말은 arr[i] < arr[i + 1]이면 i번째 오큰 수는 arr[i + 1]이다
    /// 인접한 항이 증가하는 경우
    /// 다음 항이 오큰수


    <2>. arr이 감소하는 경우
    즉, i < j 에대해 arr[i] >= arr[j]이다
    그러면 arr[i] 값이 i, i + 1, i + 2, i + 3, ... 에서 가장 큰 수이므로 
    모든 i에 대해 오큰수는 -1이다 
    여기서 오큰수를 어느정도 공유하지 않을까 추측했다
    /// 모든 항이 감소하는 경우
    /// 마지막항을 제외하고 모든 항에서 오큰수는 -1, 마지막도 -1


    <3>. arr이 감소하다가 마지막에 증가하는 경우
    즉, end - 1까지 감소하다가 end - 1 이후로는 증가하는 경우
    arr[0] <= arr[1] <= arr[2] <= arr[3] <= ... <= arr[end - 2]
    arr[end - 1] < arr[end]

    그러면 <0>에의해 end 의 오큰수는 -1,
    <1>에 의해 end - 1의 오큰수는 arr[end]가 된다
    
    0, 1, 2, ..., end - 2의 오큰수를 찾으면 된다
    해당 오큰 수는 다음과 같다

    0, 1, 2, ..., end - 2 사이에 적당한 a1 값이 존재해
    arr[a1 - 1] > arr[end] > arr[a1]이라 가정하면
    
    a1, a1 + 1, a1 + 2, ..., end - 3의 오큰수는 arr[end]이고
    0, 1, 2, ..., a1 - 1의 경우 해당 수보다 큰 수가 오른쪽에 없기에 오큰수는 -1이 된다
    만약 arr[end] <= arr[end - 2] 이면 a1은 존재하지 않고 오큰수는 -1이된다
    

    <4> arr이 감소하다가 증가하는 경우
    끝항을 1개 더 늘려서 arr[end -1] < arr[end] < arr[end + 1] 이라 가정하면
    end + 1 항은 <0>에 의해 오큰수가 -1
    end - 1, end 항은 <1>에의해 오큰수가 각각 arr[end], arr[end + 1]이된다

    그리고 나머지 0, 1, 2, ..., end - 2는

    앞과 마찬가지로 0, 1, 2, ..., end - 2에서 적당한 a1, a2가 존재한다고 가정하자 (존재 안하면 <3>의 경우이다!)
    arr[a1 + 1] > arr[end] > arr[a1],
    arr[a2 + 1] > arr[end + 1] > arr[a2]인 경우
    그러면 arr[end] > arr[end + 1] > arr[2]

    a1

    

    arr의 값들이 모두 자연수이고 arr이 유한 수열이므로 arr은 항이 인접한 순 증가 수열이나 감소수열로 분할이 가능하므로 3번의 경우를 잘 이용하면
    스택에는 
 */

namespace BaekJoon._31
{
    internal class _31_02
    {

        static void Main2(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int len = int.Parse(sr.ReadLine());
            int[] input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

            sr.Close();
            int[] result = new int[len];
            Stack<int> temp = new Stack<int>();
            // Stack<int> calc = new Stack<int>();     // 계산용!
            temp.Push(-1);

            result[len - 1] = -1;

            for (int i = len - 2; i >= 0; i--)
            {

                // 앞에께 뒤에꺼보다 작은 경우 값을 공유?
                if (input[i] < input[i + 1])
                {

                    
                    temp.Push(input[i + 1]);
                    result[i] = input[i + 1];
                }
                else if (result[i + 1] == -1)
                {

                    // 뒤에께 -1이면 즉, 뒤에 해당 수보다 큰 게 없다는 의미이므로 
                    result[i] = -1;
                    continue;
                }
                else
                {


                    while (temp.Count > 0)
                    {

                        if(temp.Peek() > input[i])
                        {

                            result[i] = temp.Peek();
                            break;
                        }
                        else if (temp.Peek() == -1)
                        {

                            result[i] = -1;
                            break;
                        }
                        else
                        {

                            // calc에 보관
                            // calc.Push(temp.Pop());
                            temp.Pop();
                        }
                    }

                    // 다시 집어 넣으면 안된다!
                    // 안쓰는건 버린다
                    // while(calc.Count > 0)
                    // {

                        // temp.Push(calc.Pop());
                    // }
                }
            }


            using (StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput())))
            {

                // 출력
                for (int i = 0; i < len; i++)
                {

                    sw.Write(result[i]);
                    sw.Write(' ');
                }
            }
        }
    }
}
