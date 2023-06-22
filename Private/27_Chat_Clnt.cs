using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

/*
날짜 : 2023. 6. 23
이름 : 배성훈
내용 : 채팅 클라
    멀티쓰레드
    tcp/ip 통신
 
    현재 닉네임 설정을 클라에서 정하고 전송하는게 아닌 서버에서 정해준 닉네임을 이용한다
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

            NetworkStream ns = tcpClient.GetStream();
            StreamWriter sw = new StreamWriter(ns);

            Thread thread = new Thread(new ParameterizedThreadStart(RecvMessage));
            thread.Start(tcpClient);


            try
            {
                while (true)
                {

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

                    Console.WriteLine(message);
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

        private static string SetName()
        {

            Console.Write("닉네임 : ");
            string name = Console.ReadLine();

            if (name == null || name == string.Empty)
            {

                Random rand = new Random();
                name = string.Format("User {0, 5}", rand.Next(1001, 65536));
            }
            Console.WriteLine($"{name}님 닉네임이 설정되었습니다.");
            return name;
        }
    }
}
