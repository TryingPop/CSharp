using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    internal class _27_Chat_Clnt
    {

        public static byte[] buffer = new byte[100];
        public static string msg = string.Empty;

        public static TcpClient tcpClient;
        public static NetworkStream ns;

        static void Main(string[] args)
        {

            string ip = "192.168.35.213";
            int port = 3303;

             tcpClient = new TcpClient(ip, port);


            Console.WriteLine("서버 연결 완료");
            ns = tcpClient.GetStream();

            Console.Clear();
            Console.WriteLine("클라이언트 접속 중...");

            try
            {

                Thread sendThread = new Thread(SendMessage);
                Thread recvThread = new Thread(RecvMessage);

                sendThread.Start();
                recvThread.Start();
            }
            finally
            {

                ns.Close();
                tcpClient.Close();
            }
        }

        public static void SendMessage()
        {


            try
            {



                while(true)
                {

                    Console.Write("보낼 메세지 : ");
                    msg = Console.ReadLine();

                    if (msg.Length >= 50)
                    {

                        msg = msg.Substring(0, 50);
                        Console.WriteLine("메시지는 최대 50글자까지만 전송이 가능합니다.");
                    }

                    byte[] sendMessage = Encoding.UTF8.GetBytes(msg);

                    ns.Write(sendMessage, 0, sendMessage.Length);
                }
            }
            catch
            {

                Console.WriteLine("에러 발생");
            }
        }

        public static void RecvMessage()
        {

            try
            {

                while (true)
                {

                    if (ns.Read(buffer, 0, buffer.Length) > 1)
                    {

                        msg = Encoding.UTF8.GetString(buffer);
                        Console.WriteLine("받은 메세지 : {0}", msg);
                    }

                    Thread.Sleep(100);
                }
            }
            catch
            {

                Console.WriteLine("에러 발생");
            }
        }
    }
}
