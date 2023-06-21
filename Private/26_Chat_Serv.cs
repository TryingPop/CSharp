using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

/*
날짜 : 2023. 6. 22
이름 : 배성훈
내용 : 채팅 서버
    멀티 쓰레드
    tcp/ip 통신

    클라와 이상없이 통신되는거 확인
    에러는 NetworkStream을 종료하니 메세지 수신에서 문제가 발생
    
    현재 닉네임을 저장하는 버전업이 필요하다
    그래서 닉네임을 저장하고, 글자 수 제한도 할 예정이다
*/

namespace Private
{
    internal class _26_Chat_Serv
    {

        public static object key = new object();   // 임계영역용 오브젝트

        public static List<TcpClient> clients = new List<TcpClient>();

        public static void Chat(object client)
        {

            TcpClient tcpClient = (TcpClient)client;
            NetworkStream ns = tcpClient.GetStream();
            StreamReader sr = new StreamReader(ns);
            string msg = string.Empty;

            clients.Add(tcpClient);

            try
            {
                while (true)
                {


                    msg = sr.ReadLine();


                    if (msg.Length != 0)
                    {

                        Monitor.Enter(key);

                        foreach (var item in clients)
                        {

                            if (item == tcpClient)
                            {

                                continue;
                            }

                            SendMessage(item, msg);
                        }
                        Monitor.Exit(key);

                        Console.WriteLine("메세지 : {0}\n전송완료", msg);
                    }
                }
            }
            catch
            {

                Console.WriteLine("전송 에러");
            }
            finally
            {

                sr.Close();

                ns.Close();

                clients.Remove(tcpClient);
                tcpClient.Close();
                Console.WriteLine("소켓 종료");
            }
        }

        private static void SendMessage(TcpClient client, string msg)
        {

            NetworkStream ns = client.GetStream();
            StreamWriter sw = new StreamWriter(ns);

            try
            {

                sw.WriteLine(msg);
                sw.Flush();
            }
            catch
            {

                Console.WriteLine("전송 실패");
            }
        }


        /// <summary>
        /// 현재 서버의 아이피 확인
        /// </summary>
        /// <returns>현재 아이피</returns>
        public static IPAddress GetIP()
        {

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }

            return IPAddress.Any;
        }

        /// <summary>
        /// 포트 번호 설정
        /// </summary>
        /// <returns>포트 번호</returns>
        public static int SetPort()
        {

            while (true)
            {
                try
                {

                    Console.Clear();
                    Console.Write("포트 입력(1001 ~ 65535) : ");

                    int port = int.Parse(Console.ReadLine());

                    if (port <= 1000 || port > 65536)
                    {

                        continue;
                    }

                    return port;
                }
                catch
                {

                    Console.WriteLine("포트 번호(1001 ~ 65535)를 다시 입력해주세요.");
                }
            }
        }

        public static void ServStart()
        {

            IPAddress ip;
            int port = 0;

            ip = GetIP();
            port = SetPort();
            TcpListener tcpListener = new TcpListener(ip, port);


            Console.Clear();
            Console.WriteLine("IP : {0}", ip.ToString());
            Console.WriteLine("Port : {0}", port.ToString());

            tcpListener.Start();
            Console.WriteLine("서버 시작");

            while (true)
            {

                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                Monitor.Enter(key);
                Console.WriteLine("클라이언트 접속 중...");

                Thread thread = new Thread(new ParameterizedThreadStart(Chat));
                thread.Start(tcpClient);
                Console.WriteLine("클라이언트 접속 완료");
                Monitor.Exit(key);
            }

        }

        static void Main(string[] args)
        {

            ServStart();
        }
    }
}
