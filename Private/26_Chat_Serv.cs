using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Asn1.Mozilla;
using System.Threading;

/*
날짜 : 2023. 6. 21
이름 : 배성훈
내용 : 채팅 서버
    멀티 쓰레드
    tcp/ip 통신
*/

namespace ConsoleApp1           // 추후 Private
{
    internal class _26_Chat_Serv
    {


        public class Clnt
        {

            public static List<Clnt> clnts = new List<Clnt>();     // 클라이언트들 모임

            public TcpClient tcpClnt;
            public NetworkStream ns;

            byte[] buffer = new byte[100];
            string msg;

            public Clnt(object clnt)
            {
                

                if (clnt as TcpClient == null)
                {

                    Console.WriteLine("변환 실패...");
                }
                this.tcpClnt = clnt as TcpClient;
                
                this.ns = this.tcpClnt.GetStream();

                clnts.Add(this);
            }

            public void ReadMessage()
            {

                if (ns.Read(buffer, 0, buffer.Length) > 0)
                {

                    msg = Encoding.UTF8.GetString(buffer);
                    Console.WriteLine("받은 메세지 : {0}", msg);
                }
            }

            public void SendMessage()
            {

                if (msg == string.Empty)
                {

                    return;
                }

                byte[] sendMessage = Encoding.UTF8.GetBytes(msg);

                for (int i = 0; i < clnts.Count; i++)
                {

                    if (clnts[i] == this)
                    {

                        continue;
                    }

                    ns.Write(sendMessage, 0, sendMessage.Length);
                }
            }

            public void Disconnect()
            {

                this.ns.Close();
                this.tcpClnt.Close();
                clnts.Remove(this);
            }
        }


        static void Main(string[] args)
        {

            StartServ();
        }


        /// <summary>
        /// Tcp 소켓 통신
        /// </summary>
        public static void StartServ()
        {

            IPAddress ip;
            int port = 0;
            TcpListener tcpListener;

            SetAddress(out ip, ref port, out tcpListener);

            Console.Clear();
            Console.WriteLine("서버 IP : {0}\n서버 Port : {1}", ip, port);

            // 읽기 시작
            Console.WriteLine("서버 대기 상태 시작");
            tcpListener.Start();

            // 받을 메시지
            string msg = string.Empty;

            // 클라이언트 읽기
            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();

                Thread thread = new Thread(ConnectClnt);
                thread.Start(tcpClient);
            }
        }

        public static IPAddress FindIP()
        {

            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addr = ipEntry.AddressList;

            for (int i = 0; i < addr.Length; i++)
            {

                if (addr[i].AddressFamily == AddressFamily.InterNetwork)
                {

                    return addr[i];
                }
            }

            return IPAddress.Any;
        }

        /// <summary>
        /// 아이피와 포트 설정하는 메소드
        /// </summary>
        public static void SetAddress(out IPAddress Ip, ref int Port, out TcpListener tcpListener)
        {

            Ip = FindIP();

            while (true) 
            {

                try
                {

                    Console.Write("서버 Port(100 ~ 65535) : ");
                    Port = int.Parse(Console.ReadLine());

                    tcpListener = new TcpListener(Ip, Port);

                    return;
                }
                catch   
                {

                    // port 번호를 잘못 입력한 경우
                    Console.Clear();
                    Console.WriteLine("Port 번호를 다시 입력해 주세요.");
                }
            }
        }

        public static void ConnectClnt(object client)
        {

            Console.WriteLine("클라이언트 접속...");
            Clnt clnt = new Clnt(client);
            Console.WriteLine("클라이언트 접속 완료");
            try
            {
                while (true)
                {

                    clnt.ReadMessage();
                    clnt.SendMessage();
                    Thread.Sleep(100);
                }
            }
            finally
            {

                clnt.Disconnect();
            }
        }
    }
}
