using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 7. 8
이름 : 배성훈
내용 : 영단어 암기는 괴로워
    문제번호 : 20920번

    조건에 맞춰 정렬하기
    나오는 빈도수, 길이가 길수록, 사전에 나오는 순서대로 우선순위를 두어 문자열 정렬
*/

namespace BaekJoon._12
{
    internal class _12_05
    {

        static void Main5(string[] args)
        {

            int[] chk = Array.ConvertAll(Console.ReadLine().Split(' '), input => int.Parse(input));
            int length = chk[0];
            int min = chk[1];

            int strLength = length;

            string[] inputs = new string[length];
            int[] counts = new int[length];

            for (int i = 0; i < length; i++)
            {

                inputs[i] = Console.ReadLine();

                // 길이 확인
                if (inputs[i].Length < min)
                {
                    inputs[i] = null;
                    i--;
                    length--;

                    continue;
                }

                // 같은 문자 보유 중인지 확인
                for (int j = 0; j < i; j++)
                {

                    if (inputs[j] == inputs[i])
                    {

                        inputs[i] = null;
                        i--;
                        length--;

                        counts[j]++;
                        break;
                    }
                }
            }

            // 정렬된 인덱스
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {

                bool change = false;

                for (int j = 0; j < i; j++)
                {

                    // 빈도수 확인
                    if (counts[i] > counts[result[j]])
                    {

                        // 빈도수가 큰 경우
                        // 한 칸씩 뒤로 미뤄서 재정렬
                        for (int k = i - 1; k >= j; k--)
                        {

                            result[k + 1] = result[k]; 
                        }

                        result[j] = i;
                        change = true;
                        break;
                    }

                    if (counts[i] == counts[result[j]])
                    {

                        // 빈도수가 같은 경우

                        // 문자열 길이 확인
                        if (inputs[i].Length > inputs[result[j]].Length)
                        {

                            // 길이가 긴 경우
                            // 빈도수가 큰 경우
                            for (int k = i - 1; k >= j; k--)
                            {

                                result[k + 1] = result[k];
                            }

                            result[j] = i;
                            change = true;
                            break;
                        }
                        else if (inputs[i].Length == inputs[result[j]].Length)
                        {

                            // 길이가 같은경우

                            // 알파벳 순서 확인
                            for (int k = 0; k < inputs[i].Length; k++)
                            {

                                // 사전으로 먼저 배열 되었는지 확인
                                // 소문자만 있어서 따로 변환 안했다
                                if (inputs[i][k] > inputs[result[j]][k])
                                {

                                    // 
                                    for (int l = i - 1; l >= j; l--)
                                    {

                                        result[l + 1] = result[l];
                                    }

                                    result[j] = i;
                                    change = true;
                                    break;
                                }
                            }

                            if (change)
                            {

                                break;
                            }
                        }
                    }
                }

                if (!change)
                {

                    result[i] = i;
                }
            }

            for (int i = 0; i < length; i++)
            {

                Console.WriteLine(inputs[result[i]]);
            }
        }
    }
}
