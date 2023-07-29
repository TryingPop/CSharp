using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 7. 30
이름 : 배성훈
내용 : C#으로 온라인 게임 서버 만들기 (04)
    CHeartbeatSender, BufferManager

    CHearbeatSender 게임과 관련된 클래스인거 같다
    BufferManager는 비동기 소켓 연결에 도움을 주기 위해 사용하는 클래스 같다
*/

namespace Private
{
    public partial class _30_온라인_게임_서버_만들기
    {

        public class CHeartbeatSender
        {

            CUserToken server;
            Timer timer_heartbeat;
            uint interval;

            float elapsed_time;         // 경과 시간


            public CHeartbeatSender(CUserToken server, uint interval)
            {

                this.server = server;
                this.interval = interval;
                this.timer_heartbeat = new Timer(this.on_timer, null, Timeout.Infinite, this.interval * 1000);
            }

            void on_timer(object state)
            {

                send();
            }

            void send()
            {

                CPacket msg = CPacket.create((short)CUserToken.SYS_UPDATE_HEARTBEAT);
                this.server.send(msg);
            }

            public void update(float time)
            {

                this.elapsed_time += time;
                if (this.elapsed_time < this.interval)
                {

                    return;
                }

                this.elapsed_time = 0.0f;
                send();
            }

            public void stop()
            {

                this.elapsed_time = 0;
                this.timer_heartbeat.Change(Timeout.Infinite, Timeout.Infinite);
            }

            public void play()
            {

                this.elapsed_time = 0;
                this.timer_heartbeat.Change(0, this.interval * 1000);
            }
        }

        /// <summary>
        /// 소켓 IO 작업에 사용하기 위해 분할 및 SocketAsyncEventArgs 갳체에 할당할 수 있는 단일 대형 버퍼를 만든다
        /// 이를 통해 버퍼를 쉽게 재사용하고 힙 메모리 누수를 방지할 수 있다
        /// 
        /// BufferManager 클래스에 노출된 작업은 스레드로부터 안전하지 않다
        /// </summary>
        internal class BufferManager
        {

            int m_numBytes;                 // 버퍼풀에 의해 통제되는 전체 바이트 수
            byte[] m_buffer;                // 버퍼 관리자가 유지 관리하는 기본 바이트 배열
            Stack<int> m_freeIndexPool;
            int m_currentIndex;
            int m_bufferSize;

            public BufferManager(int totalBytes, int bufferSize)
            {

                m_numBytes = totalBytes;
                m_currentIndex = 0;
                m_bufferSize = bufferSize;
                m_freeIndexPool = new Stack<int>();
            }

            /// <summary>
            /// 버퍼풀에의해 버퍼 공간 할당
            /// </summary>
            public void InitBuffer()
            {

                m_buffer = new byte[m_numBytes];
            }

            public bool SetBuffer(SocketAsyncEventArgs args)
            {

                if (m_freeIndexPool.Count > 0)
                {

                    args.SetBuffer(m_buffer, m_freeIndexPool.Pop(), m_bufferSize);
                }
                else
                {

                    if ((m_numBytes - m_bufferSize < m_currentIndex))
                    {

                        return false;
                    }

                    args.SetBuffer(m_buffer, m_currentIndex, m_bufferSize);
                    m_currentIndex += m_bufferSize;
                }

                return true;
            }

            /// <summary>
            /// SocketAsyncEventArgs 객체를 버퍼에서 제거한다
            /// </summary>
            /// <param name="args"></param>
            public void FreeBuffer(SocketAsyncEventArgs args)
            {

                m_freeIndexPool.Push(args.Offset);
                args.SetBuffer(null, 0, 0);
            }
        }
    }
}
