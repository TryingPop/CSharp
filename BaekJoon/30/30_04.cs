using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 12. 18
이름 : 배성훈
내용 : 양팔 저울
    문제번호 : 2629번
*/

namespace BaekJoon._30
{
    internal class _30_04
    {

        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            sr.ReadLine();
            int[] weights = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int len = int.Parse(sr.ReadLine());
            int[] chks = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

            sr.Close();


        }
    }
}
