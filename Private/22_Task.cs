using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private
{
    internal class _22_Task
    {
        private string TaskWithReturn()
        {
            Console.WriteLine($"Start");
            Thread.Sleep(3000);
            Console.WriteLine($"End");
            return "Retrun";
        }

        private void CancelTask(CancellationTokenSource cts)
        {
            Thread.Sleep(1000);
            cts.Cancel();
        }

        private void MainMethod()
        {
            Task<string> t = new Task<string>(TaskWithReturn);
            t.Start();

            //Task<string> d = new Task<string>(TaskWithReturn);
            // d.Start();
            // d.Dispose(); // 실행 중에는 사용 불가
            Console.WriteLine(t.Status);
            

            CancellationTokenSource cts = new CancellationTokenSource();
            Task.Run(() => CancelTask(cts));

            try
            {
                t.Wait(cts.Token); // Wait이 취소되었다
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Wait Canceled");
            }

            Console.WriteLine("Main Thread End");

            Console.WriteLine(t.Result); // t의 반환값을 가져온다
            Thread.Sleep(5000);
            Console.WriteLine("Main End");
        }


        static void Main22(string[] args)
        {
            var t = new _22_Task();
            t.MainMethod();
        }
    }
}

// 참고 사이트
// https://rito15.github.io/posts/cs-task/

// Task 상태
// https://songsun0331.tistory.com/entry/Task%EC%9D%98-%EC%83%81%ED%83%9C-%EC%A0%95%EC%9D%98-%EC%99%80-%EB%B3%80%ED%99%94