using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

/*
날짜 : 2023. 7. 18
이름 : 배성훈
내용 : 채팅 서버
    멀티 쓰레드
    tcp/ip 통신

    좀비 소켓 문제 해결
    로그인 시, 서버에서 ip 체크를하고, ban >> 명령어를 가진 데이터 전송
    혹은 중간에 서버에서 클라이언트 벤을 때리는 경우를 구현하기 위해 코드 작성

    서버에서 벤 명령어를 가진 문자를 보내면 클라이언트 쪽에서 문자를 읽고 서버와 연결을 끊는다
    그런데, 클라는 해제되는 방면에 서버는 해제 안되는 현상 발생(좀비 소켓)

    구글링으로 알아보니 한쪽이 해제하는 것을 못 읽을 경우에 발생한다고 한다
    시행착오와 코드를 찾아본 결과 서버에서 ReadMessage 함수 때문에 해제를 못읽는 것으로 추정된다

    그래서 클라이언트 쪽에서 b 되었다는 확인 문자를 서버에 보내게 수정
    그러면 서버는 클라의 문자를 읽고 clnt 객체 안에 벤 변수를 활성화
    그리고 예외를 발생시켜 서버에서 소켓 해제 작업 진행
*/

namespace Private
{
    internal class _26_Chat_Serv
    {

        public static object key = new object();   // 임계영역용 오브젝트

        // public static List<TcpClient> clients = new List<TcpClient>();
        public static Dictionary<string, TcpClient> clients = new Dictionary<string, TcpClient>();  // 이름과 클라이언트 소켓을 저장하는 딕셔너리

        public static TcpListener tcpListener;
        static void Main26(string[] args)
        {

            StartServ();
        }

        public class Clnt : IDisposable
        {

            public static Dictionary<string, Clnt> clients = new Dictionary<string, Clnt>();

            TcpClient client;
            NetworkStream ns;
            StreamReader sr;
            StreamWriter sw;

            string msg = string.Empty;
            char color = 'w';
            public string name = string.Empty;

            public bool ban = false;

            public Clnt(TcpClient client)
            {

                try
                {
                    this.client = client;
                    this.ns = this.client.GetStream();
                    this.sr = new StreamReader(this.ns);
                    this.sw = new StreamWriter(this.ns);

                    this.GetRandomName();

                    this.color = 'r';
                    this.msg = "[소켓 연결]";
                    PrintChat();
                }
                catch
                {

                    this.Dispose();
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
            public void Dispose()
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

                // Console.WriteLine($"접속 중인 인원 : {clients.Count}");

                this.msg = string.Format("[소켓 해제]");
                this.color = 'r';
                this.PrintChat();
                GC.Collect();
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
                else if (chk == "b")
                {

                    this.ban = true;
                    this.msg = string.Format("[강퇴된 유저의 접속 시도]");
                    this.color = 'r';
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
            public void SetName(string name)            // null or string.Empty는 클라에서 체크
            {

                if (Clnt.clients.ContainsKey(name))
                {

                    this.color = 'y';
                    this.msg = $"[닉네임 변경 실패]{name}";
                    this.SendMessage($"{name}은 존재하는 닉네임입니다.", 4);
                    return;
                }


                this.color = 'y';
                this.msg = $"[닉네임 변경 성공]{this.name}";
                this.SendMessage($"sn|{name}");
                // 클라에서 처리
                // this.SendMessage($"{name}으로 닉네임이 변경되었습니다.", 4);
                // this.SendMessage($"-clear 명령어를 입력하시면 변경된 닉네임을 확인할 수 있습니다.", 4);

                Clnt.clients.Remove(this.name);
                this.name = name;
                Clnt.clients[this.name] = this;
            }

            /// <summary>
            /// User + 01001 ~ 65536 사이의 임의의 숫자를 합친 닉네임 설정
            /// </summary>
            /// <returns>User01001 ~ User65535</returns>
            private void GetRandomName()
            {

                Random rand = new Random();
                string name;

                while (true)
                {

                    name = string.Format("User{0:D5}", rand.Next(1001, 65536));

                    if (!Clnt.clients.ContainsKey(name))
                    {

                        break;
                    }
                }

                if (this.name != string.Empty)
                {

                    Clnt.clients.Remove(this.name);
                }

                this.name = name;
                Clnt.clients[this.name] = this;
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

                Thread thread = new Thread(StartChat);
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

            // Console.WriteLine($"현재 유저 수 : {Clnt.clients.Count}");

            try
            {

                if (clnt.ban)
                {

                    clnt.SendMessage($"b|{clnt.name}");
                }
                else
                {

                    clnt.SendMessage($"s|{clnt.name}");
                }

                while (!clnt.ban)
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

                    if (clnt.ban)
                    {

                        throw null;
                    }
                }
            }
            catch { }
            finally
            {

                clnt.Dispose();
            }
        }
    }
}