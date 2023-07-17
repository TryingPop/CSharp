using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 7. 15
이름 : 배성훈
내용 : 수 정렬하기 2
    문제번호 : 2751번

    병합정렬로 정렬하기!
*/

namespace BaekJoon._18
{
    internal class _18_01
    {

        static void Main1(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int len = int.Parse(sr.ReadLine());
            int[] nums = new int[len];

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < len; i++)
            {

                nums[i] = int.Parse(sr.ReadLine());
            }
            sr.Close();
            
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            // 병합정렬 로직 !



            Console.WriteLine(sb);

            sw.Close();
        }
    }
}
