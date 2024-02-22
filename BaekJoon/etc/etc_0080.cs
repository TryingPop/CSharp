using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 2. 22
이름 : 배성훈
내용 : 소변기
    문제번호 : 3186번

    조건에 맞는 상황 구현 문제다
*/

namespace BaekJoon.etc
{
    internal class etc_0080
    {

        static void Main80(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] info = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            
            int chk = 0;
            int curTime = 0;
            bool used = false;
            bool isOn = false;
            for (int i = 0; i < info[2]; i++)
            {

                curTime++;
                int cur = sr.Read() - '0';
                if (cur == 1 && !isOn)
                {

                    chk++;
                    if (chk == info[0])
                    {

                        used = true;
                        isOn = true;
                        chk = 0;
                    }
                }
                else if (cur == 0 && isOn)
                {

                    chk++;
                    if (chk == info[1])
                    {

                        isOn = false;
                        sw.WriteLine(curTime);
                        chk = 0;
                    }
                }
                else chk = 0;
            }

            if (isOn)
            {

                sw.WriteLine(curTime + info[1] - chk);
            }

            else if (!used)
            {

                sw.WriteLine("NIKAD");
            }
            sr.Close();
            sw.Close();
        }
    }
}
