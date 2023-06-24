using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

/*
날짜 : 2023. 6. 24
이름 : 배성훈
내용 : 채팅 서버
    멀티 쓰레드
    tcp/ip 통신

    귓속말 기능 추가
    이름 바꾸기 기능 추가

    귓속말을 읽는 방법 때문에 이름은 띄어쓰기가 불가능하게 했다
    또한 이전 코드는 StreamWriter를 SendMessage 함수에서 매번 생성하기에
    메모리 낭비가 심한거 같아 클래스를 생성하고 클래스를 이용하는 형식으로 바꿨다

    그리고 귓말, 이름바꾸기 등을 표현하기 위해서 콘솔창에 색상 바꾸는 것을 추가했다

    앞으로 추가할껀, 유저의 행동을 콘솔창에 보여주는 것 뿐만 아니라 데이터로 저장하는 것과
    송수신 되는 데이터를 문자열이 아닌 구조체나 클래스로 바꿀 것이다.
*/

namespace Private
{
    internal class _26_Chat_Serv
    {

        public static object key = new object();   // 임계영역용 오브젝트

        // public static List<TcpClient> clients = new List<TcpClient>();
        public static Dictionary<string, TcpClient> clients = new Dictionary<string, TcpClient>();  // 이름과 클라이언트 소켓을 저장하는 딕셔너리

        public static TcpListener tcpListener;

        public class Clnt
        {

            public static Dictionary<string, Clnt> clients = new Dictionary<string, Clnt>();

            TcpClient client;
            NetworkStream ns;
            StreamReader sr;
            StreamWriter sw;

            string msg = string.Empty;
            char color = 'w';
            public string name = string.Empty;

            public Clnt(TcpClient client)
            {

                try
                {
                    this.client = client;
                    this.ns = this.client.GetStream();
                    this.sr = new StreamReader(this.ns);
                    this.sw = new StreamWriter(this.ns);

                    this.SetName();

                    this.color = 'r';
                    this.msg = "[소켓 연결]";
                    PrintChat();
                }
                catch
                {

                    this.OnDisconnect();
                }
            }

            /// <summary>
            /// 이 소켓으로 메세지 문자열 전송
            /// </summary>
            /// <param name="message">보낼 메세지</param>
            /// <param name="option">글자 색상</parma>
            public void SendMessage(string message = null, int option = 0)
            {

                try
                {

                    if (option == 1)    // yellow
                    {

                        message = string.Format("cy|{0}", message);
                    }
                    else if (option == 2)   // red
                    {

                        message = string.Format("cr|{0}", message);
                    }
                    else if (option == 3)   // blue
                    {

                        message = string.Format("cb|{0}", message);
                    }
                    else if (option == 4)   // green
                    {

                        message = string.Format("cg|{0}", message);
                    }


                    sw.WriteLine(message);
                    sw.Flush();
                }
                catch
                {

                    this.color = 'y';
                    this.msg = string.Format("{0}에게 메세지 전송 실패", this.name);
                    sw.Flush();
                }
            }

            /// <summary>
            /// 해당 소켓으로 "이름 : 메세지"로 전송할 때 사용하는 메소드, 즉 채팅 내용 전달 메소드 
            /// </summary>
            /// <param name="name">보낸 사람 이름</param>
            /// <param name="message">보낼 메세지</param>
            /// <param name="option">글자 색상</param>
            public void SendMessage(string name, string message, int option = 0)
            {

                try
                {

                    if (option == 1)
                    {

                        name = string.Format("cy|{0}", name);
                    }
                    else if (option == 2)
                    {

                        name = string.Format("cr|{0}", name);
                    }
                    else if (option == 3)
                    {

                        name = string.Format("cb|{0}", name);
                    }
                    else if (option == 4)
                    {

                        name = string.Format("cb|{0}", name);
                    }

                    sw.WriteLine(string.Format("{0} : {1}", name, message));
                    sw.Flush();
                }
                catch
                {

                    this.color = 'y';
                    this.msg = string.Format("{0}에게 메세지 전송 실패", this.name);
                    sw.Flush();
                }
            }

            /// <summary>
            /// 모든 유저에게 메세지 전달, 자기자신은 녹색 글로 전달한다
            /// </summary>
            /// <param name="option"></param>
            public void SendAllUserMessage(int option = 0)
            {

                foreach (var data in Clnt.clients)
                {

                    if (data.Key != this.name)
                    {

                        data.Value.SendMessage(this.name, this.msg);
                    }
                    else
                    {

                        data.Value.SendMessage(this.msg, 4); // 자기자신은 녹색 칼라로 전달
                    }
                }
            }

            /// <summary>
            /// 해당 소켓으로 부터 전송 받은 메세지, msg에 저장
            /// </summary>
            /// <returns>메세지를 전송 받았는지 여부</returns>
            public bool RecvMessage()
            {

                this.msg = sr.ReadLine();

                if (this.msg == null || this.msg == string.Empty)
                {

                    return false;
                }

                return true;
            }

            /// <summary>
            /// 소켓 해제, 즉 이 클래스의 참조 카운터를 0으로 만듦
            /// </summary>
            public void OnDisconnect()
            {

                try
                {

                    Clnt.clients.Remove(this.name);
                }
                catch { }

                try
                {

                    this.sw?.Close();
                }
                catch { }

                try
                {

                    this.sr?.Close();
                }
                catch { }

                try
                {

                    this.ns?.Close();
                }
                catch { }

                try
                {

                    this.client?.Close();
                }
                catch { }

                this.msg = string.Format("[소켓 해제]");
                this.color = 'r';
                this.PrintChat();
            }

            /// <summary>
            /// 특수 명령어 확인 및 행동 기록 메소드
            /// 서버가 아닌 클라에서 명령어 구분을 위한 '|' 입력 시 전송 실패되게 했다
            /// </summary>
            /// <returns>메세지 전송이 필요한가 여부</returns>
            public bool ChkCommand()
            {

                string chk = msg.Split('|')[0]; // 앞에서 null 체크를 했고 클라에서 '|' 문자 체크하므로 try - catch 구문 제외
                if (chk == this.msg) { }

                // 닉네임 변경
                else if (chk == "sn")
                {

                    string beforename = this.name;

                    this.SetName(msg.Substring(3));

                    this.SendMessage(string.Format("{0}로 닉네임이 변경되었습니다.", this.name), 4);

                    this.msg = $"[변경]{beforename}";
                    this.color = '4';
                    return false;
                }
                else if (chk == "w")        // 귓속말 기능
                {

                    if (clients.ContainsKey(msg.Split('|')[1]))
                    {

                        clients[msg.Split('|')[1]].SendMessage(this.name, msg.Split('|')[2], 3);

                        this.msg = string.Format("[성공]{0} -> {1}", msg.Split('|')[1], msg.Split('|')[2]);
                        this.color = 'b';
                    }
                    else
                    {

                        this.SendMessage("존재하지 않는 닉네임입니다.", 1);
                        this.msg = string.Format("[실패]{0} -> {1}", msg.Split('|')[1], msg.Split('|')[2]);
                        this.color = 'b';
                    }

                    return false;
                }

                this.msg = string.Format("{0}", this.msg);
                this.color = 'w';
                return true;
            }

            /// <summary>
            /// 유저 행동 콘솔에 기록하기 위한 메소드
            /// </summary>
            public void PrintChat()
            {

                if (this.msg == null || this.msg == string.Empty)
                {

                    return;
                }

                this.SetColor();
                Console.WriteLine("{0} : {1}", this.name, this.msg);
                this.SetColor();

                this.msg = string.Empty;
            }

            /// <summary>
            /// 콘솔 칼라 적용 메소드
            /// </summary>
            private void SetColor()
            {

                if (this.color == 'r')
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (this.color == 'y')
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (this.color == 'b')
                {

                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (this.color == 'g')
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {

                    Console.ResetColor();
                }

                this.color = 'w';
            }

            /// <summary>
            /// 이름 설정 메소드
            /// </summary>
            /// <param name="name">바꿀 이름</param>
            public void SetName(string name = null)
            {

                bool setRandName = (name == null || name == string.Empty) ? true : false;

                try
                {

                    Clnt.clients.Remove(this.name); // 초기 생성인 경우 에러 발생한다 
                }
                catch { }

                while (true)
                {

                    if (setRandName)
                    {

                        name = Clnt.GetRandomName();
                    }

                    if (Clnt.clients.ContainsKey(name))
                    {

                        setRandName = true;
                        continue;
                    }

                    this.name = name;

                    if (this.name.Length >= 10)
                    {

                        this.name = this.name.Substring(0, 9);
                        SendMessage("닉네임은 최대 9글자까지만 가능합니다.", 1);
                    }

                    Clnt.clients[this.name] = this;
                    return;
                }
            }

            /// <summary>
            /// User + 01001 ~ 65536 사이의 임의의 숫자를 합친 닉네임 설정
            /// </summary>
            /// <returns>User01001 ~ User65535</returns>
            private static string GetRandomName()
            {

                Random rand = new Random();
                return string.Format("User{0:D5}", rand.Next(1001, 65536));
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

        /// <summary>
        /// 서버 시작
        /// </summary>
        public static void StartServ()
        {

            IPAddress ip = GetIP();
            int port = SetPort();

            tcpListener = new TcpListener(ip, port);
            tcpListener.Start();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[서버 시작]");
            Console.WriteLine("IP : {0}\nPort : {1}", ip.ToString(), port.ToString());
            Console.ResetColor();

            while (true)
            {

                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                Monitor.Enter(key);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("클라이언트 접속 시도...");
                Console.ResetColor();
                Clnt clnt = new Clnt(tcpClient);

                Thread thread = new Thread(new ParameterizedThreadStart(StartChat));
                thread.Start(clnt);

                Monitor.Exit(key);
            }
        }

        /// <summary>
        /// 해당 소켓의 채팅 시작
        /// </summary>
        /// <param name="client">채팅 시작</param>
        public static void StartChat(object client)
        {

            Clnt clnt = (Clnt)client;
            Clnt.clients[clnt.name] = clnt;

            try
            {

                while (true)
                {

                    if (clnt.RecvMessage())
                    {

                        Monitor.Enter(key);
                        if (clnt.ChkCommand())
                        {

                            clnt.SendAllUserMessage();
                        }

                        clnt.PrintChat();
                        Monitor.Exit(key);
                    }

                }
            }
            catch
            {

                clnt.OnDisconnect();
            }

        }

        static void Main(string[] args)
        {

            StartServ();
        }
    }
}