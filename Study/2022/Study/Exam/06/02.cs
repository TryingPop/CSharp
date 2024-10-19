using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.29
 * 내용 : 피보나치 연습문제
 */

namespace Exam._06
{
    internal class _06_02
    {
        static void Main2(string[] args)
        {
            string path = @"C:\Users\502\Desktop\Gugudan.txt";

            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);

                for (int x = 2; x <= 9; x++)
                {
                    sw.WriteLine($"{x}단");
                    for (int y = 1; y <= 9; y++)
                    {
                        sw.WriteLine($"{x} X {y} = {x*y:00}");
                    }
                    sw.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }

            Console.WriteLine("구구단 파일 생성 완료...");
        }
    }
}
