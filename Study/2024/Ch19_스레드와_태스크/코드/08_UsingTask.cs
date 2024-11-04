using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 5
이름 : 배성훈
내용 : System.Threading.Tasks.Task
    교재 p 677 ~ 683

    병렬 처리는 하나의 작업을 여러 작업자가 나눠서 수행한 뒤 다시 하나의 결과로 만드는 것을 병렬 처리라 한다.
    비동기 처리는 작업을 시작한 후 작업의 결과가 나올 때까지 마냥 대기하는게 아닌 곧이어 다른 작업을 수행하다가 A가 끝나면 그 결과를 받아내는 처리 방식을 말한다.
    Task도 Thread를 이용해 구현되었다.
*/

namespace Study._2024.Ch19_스레드와_태스크.코드
{
    internal class _08_UsingTask
    {

        static void Main8(string[] args)
        {

            string srcFile = args[0];

            // 파일 복사 메소드
            Action<object> FileCopyAction = (object state) =>
            {

                string[] paths = (string[])state;
                File.Copy(paths[0], paths[1]);

                Console.WriteLine("TaskID:{0}, ThreadID:{1}, {2} was copied to {3}",
                    Task.CurrentId, Thread.CurrentThread.ManagedThreadId, paths[0], paths[1]);
            };

            Task t1 = new Task(
                FileCopyAction,
                new string[] { srcFile, srcFile + ".copy1" });

            // 생성과 동시에 시작
            Task t2 = Task.Run(() =>
            {

                FileCopyAction(new string[] { srcFile, srcFile + ".copy2" });
            });

            t1.Start();

            Task t3 = new Task(
                FileCopyAction,
                new string[] { srcFile, srcFile + ".copy3" });

            // 해당 Task 동기로 실행
            t3.RunSynchronously();

            t1.Wait();
            t2.Wait();
            t3.Wait();
        }
    }
}
