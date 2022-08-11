using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private
{
    internal class _21_Thread
    {
        static void Main21(string[] args)
        {
            Thread sub = new Thread(Print1);
            sub.Start();

            Task task = new Task(Print1);
            task.Start();

            //Print();

            for (int i=1; i<=10; i++)
            {
                Console.WriteLine("Main Thread...");
                Thread.Sleep(500);
            }

            try
            {
                sub.Abort();
            }
            catch (Exception e)
            {
                Console.WriteLine("sub Thread 종료");
                Console.WriteLine("Process end...");
            }
            //task.Wait();


        }
        public static void Print1()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Sub Thread...");
                Thread.Sleep(500);
            }
        }

        public async static void Print2()
        {
            await Task.Delay(500);

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Sub Thread...");
                Thread.Sleep(500);
            }
        }

    }
}
