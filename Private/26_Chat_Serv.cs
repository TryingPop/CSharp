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

    닉네임을 딕셔너리로 저장한다
    클라쪽에서 연결과 동시에 이름을 같이 전송하니 데이터 수신이 안된다

    컨텍스트 스위칭으로 데이터 손실인지 아니면 네트워크 전송에 따른 데이터 손실인지 모르겠다
    일단은 콘솔에서 보기 좋게 만들기 위해 콘솔창 지우는 쪽부터 연습했다
*/

namespace Private
{
    internal class _26_Chat_Serv
    {

        public static object key = new object();   // 임계영역용 오브젝트

        // public static List<TcpClient> clients = new List<TcpClient>();
        public static Dictionary<string, TcpClient> clients = new Dictionary<string, TcpClient>();


        public static void Chat(object client)
        {

            TcpClient tcpClient = (TcpClient)client;
            NetworkStream ns = tcpClient.GetStream();
            StreamReader sr = new StreamReader(ns);

            string msg = string.Empty;
            string name = SetName();

            clients[name] = tcpClient;


            try
            {
                while (true)
                {


                    msg = sr.ReadLine();

                    if (msg.Length > 50)
                    {

                        msg.Substring(0, 50);
                    }

                    if (msg.Length != 0)
                    {

                        Monitor.Enter(key);

                        foreach (var item in clients)
                        {

                            /*
                            // 자기자신은 제외하는 코드
                            if (item == tcpClient)
                            {

                                continue;
                            }
                            */

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

                clients.Remove(name);
                tcpClient.Close();
                Console.WriteLine("소켓 종료");
            }
        }

        public static string SetName(string name = null)
        {

            bool setRandName = (name == null || name == string.Empty) ? true : false;


            while (true)
            {

                if (setRandName)
                {

                    name = SetRandomName();
                }

                if (clients.ContainsKey(name))
                {

                    setRandName = true;
                    continue;
                }

                return name;
            }
        }

        public static string SetRandomName()
        {

            Random rand = new Random();
            return string.Format("User{0, 5}", rand.Next(1001, 65535));
        }

        private static void SendMessage(KeyValuePair<string, TcpClient> item, string msg)
        {

            NetworkStream ns = item.Value.GetStream();
            StreamWriter sw = new StreamWriter(ns);

            try
            {

                sw.WriteLine(string.Format("{0} : {1}", item.Key, msg));
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
