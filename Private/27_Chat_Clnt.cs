using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

/*
날짜 : 2023. 7. 15
이름 : 배성훈
내용 : 채팅 클라
    멀티쓰레드
    tcp/ip 통신

    EnterServ 메소드를 이용해
    처음에 접속할 서버의 IP, Port 입력을 받게했고 통신이 성공할 때까지 계속 입력을 받는다

    그리고 명령어 추가
    -clear : 콘솔창 초기화
    -quit : 프로그램 종료
*/

namespace Private
{
    internal class _27_Chat_Clnt
    {

        public static string msg = string.Empty;        // 전송할 메세지
        public static string name = string.Empty;       // 닉네임

        public static TcpClient tcpClient;              // 클라이언트
        public static string ip;
        public static int port;


        static void Main27(string[] args)
        {


            EnterServ();
            NetworkStream ns;
            StreamWriter sw;

            Thread thread;          // 수신용 쓰레드

            ns = tcpClient.GetStream();
            sw = new StreamWriter(ns);

            // 수신용 쓰레드
            thread = new Thread(new ParameterizedThreadStart(RecvMessage));
            thread.Start(tcpClient);

            IntroMessage();
            Console.WriteLine("서버에 접속하신 것을 환영 합니다.");

            try
            {

                // 전송을 목적으로 만들어진 코드
                while (true)
                {

                    // 전송할 메세지 읽기
                    msg = Console.ReadLine();

                    // 48자 넘어가면 48자로 짜른다
                    // 서버에서 할려고 했으나 클라에게 부담을 주는게 맞다고 생각해 클라로 옮겼다
                    if (msg.Length >= 48)
                    {

                        msg = msg.Substring(0, 48);
                        Console.WriteLine("대화는 48자 이상 넘어갈 수 없습니다.");
                    }

                    if (ChkCommand(ref msg))
                    {

                        continue;
                    }

                    // 메시지 전송 및 버퍼 초기화
                    sw.WriteLine(msg);
                    sw.Flush();

                    // 0.1초간 대기
                    // 서버 과부하 방지용 코드
                    Thread.Sleep(100);
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

            return;
        }

        public static void EnterServ()
        {

            while (true)
            {

                Console.WriteLine("프로그램 종료 시 ip에 -quit 입력");
                Console.Write("접속할 IP : ");
                ip = Console.ReadLine();

                if (ip.ToUpper() == "-QUIT")
                {

                    Environment.Exit(0);
                }


                try
                {

                    Console.Write("접속할 Port : ");
                    port = int.Parse(Console.ReadLine());   // 형 변환에서 오류생길 수 있다

                    Console.WriteLine("서버와 연결 시도... ");
                    tcpClient = new TcpClient(ip, port);    // 클라이언트 연결 시도

                    break;
                }
                catch   // 실패한 경우 재시도
                {

                    Console.Clear();
                    Console.WriteLine("서버와 연결이 실패했습니다.");

                    continue;
                }
            }

            Console.WriteLine();
        }

        public static void IntroMessage()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[서버 정보]");
            Console.WriteLine($"서버 IP : {ip}");
            Console.WriteLine($"서버 Port : {port}");
            Console.ResetColor();
        }
        /// <summary>
        /// 메세지를 받는 함수
        /// </summary>
        /// <param name="tcpClient">수신 받는 소켓</param>
        private static void RecvMessage(object tcpClient)
        {

            NetworkStream ns = ((TcpClient)tcpClient).GetStream();
            StreamReader sr = new StreamReader(ns);
            string message = string.Empty;

            try
            {

                // 메세지 수신 및 콘솔창에 출력
                while (true)
                {

                    message = sr.ReadLine();

                    // 채팅 입력 중이면 줄 띄움 실행
                    if (Console.CursorLeft != 0)
                    {

                        Console.WriteLine();
                    }

                    ReadMessage(message);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool ChkCommand(ref string message)
        {

            if (message.Contains('|'))      // 명령어 입력에 방해될거 같아서 금지어 설정
            {

                ReadMessage("cr|특수문자 '|'는 사용할 수 없는 문자입니다.");
                return true;
            }

            if (message[0] != '-')
            {
                return false;
            }

            string[] cmd = message.Split(' ');

            try
            {
                if (message.ToUpper() == "-HELP")
                {

                    ReadMessage("cy|사용 가능한 명령어와 주의사항");
                    Console.WriteLine();
                    ReadMessage("cy|-s name [원하는 닉네임]");
                    ReadMessage("cy|닉네임의 경우 띄어쓰기가 불가능합니다.");
                    Console.WriteLine();
                    ReadMessage("cy|-w [귓속말 대상] [귓속말 내용] ");
                    ReadMessage("cy|귓속말은 파란색으로 표현됩니다.");
                    ReadMessage("cy|귓속말 대상의 대소문자에 유의하십시오.");
                    Console.WriteLine();
                    ReadMessage("cy|-clear");
                    ReadMessage("cy|대화내용 정리");
                    Console.WriteLine();
                    ReadMessage("cy|-quit or Quit");
                    ReadMessage("cy|프로그램 종료");
                    return true;
                }
                else if (message.ToUpper() == "-CLEAR")
                {

                    IntroMessage();
                    return true;
                }
                else if (message.ToUpper() == "-QUIT")
                {

                    Environment.Exit(0);
                }
                else if (cmd[0].ToUpper() == "-S")    // set의 약자로 사용
                {

                    if (cmd[1] == "name")
                    {

                        if (cmd[2].Length > 0)
                        {

                            message = $"sn|{cmd[2]}";
                        }
                        else
                        {

                            RecvMessage("cy|닉네임을 입력해 주세요.");
                            return true;
                        }
                    }
                }
                else if (cmd[0].ToUpper() == "-W")    // whisper의 약자로 사용
                {

                    message = $"w|{cmd[1]}|" + message.Substring(2 + cmd[1].Length + 2);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                ReadMessage("cy|명령어를 확인하고 싶으시면 다음을 입력하세요.");
                ReadMessage("cy|-help");
                return true;
            }

            return false;
        }


        /// <summary>
        /// 수신한 메세지 읽기
        /// </summary>
        /// <param name="message">읽을 메세지</param>
        private static void ReadMessage(string message)
        {

            string chk = message.Split('|')[0];

            if (chk == message)
            {

                Console.WriteLine(message);
            }
            else if (chk == "cy")
            {

                SetColorString('y', message);
            }
            else if (chk == "cr")
            {

                SetColorString('r', message);
            }
            else if (chk == "cb")
            {

                SetColorString('b', message);
            }
            else if (chk == "cg")
            {

                SetColorString('g', message);
            }
            else
            {

                Console.WriteLine(message);
            }
        }

        /// <summary>
        /// 칼라 해석
        /// </summary>
        /// <param name="color">칼라 종류</param>
        /// <param name="message">읽을 문자</param>
        public static void SetColorString(char color, string message)
        {

            if (color == 'y')
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (color == 'r')
            {

                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == 'b')
            {

                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (color == 'g')
            {

                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine(message.Substring(3));

            Console.ResetColor();

            return;
        }
    }
}