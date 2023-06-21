using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

/*
날짜 : 2023. 6. 22
이름 : 배성훈
내용 : 채팅 클라
    멀티쓰레드
    tcp/ip 통신
 
    닉네임 설정하게 추가할 예정
*/

namespace Private
{
    internal class _27_Chat_Clnt
    {

        public static string msg = string.Empty;

        public static TcpClient tcpClient;

        static void Main(string[] args)
        {

            string ip = "192.168.35.213";
            int port = 3303;

            tcpClient = new TcpClient(ip, port);
            Console.WriteLine("서버 접속 완료");

            Thread thread = new Thread(new ParameterizedThreadStart(RecvMessage));
            thread.Start(tcpClient);

            NetworkStream ns = tcpClient.GetStream();
            StreamWriter sw = new StreamWriter(ns);

            try
            {
                while (true)
                {

                    Console.Write("보낼 메세지 : ");
                    msg = Console.ReadLine();

                    sw.WriteLine(msg);
                    sw.Flush();
                }
            }
            catch
            {

                Console.WriteLine("전송 에러");
            }
            finally
            {

                thread.Abort();

                sw.Close();
                ns.Close();
                tcpClient.Close();
            }
        }

        private static void RecvMessage(object tcpClient)
        {

            NetworkStream ns = ((TcpClient)tcpClient).GetStream();
            StreamReader sr = new StreamReader(ns);
            string message = string.Empty;

            try
            {
                while (true)
                {
                    message = sr.ReadLine();

                    Console.WriteLine("받은 메세지 : {0}", message);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("수신 에러");
                Console.WriteLine(ex.Message);
            }
            finally
            {

                sr.Close();
                ns.Close();
                ((TcpClient)tcpClient).Close();
            }
        }
    }
}
