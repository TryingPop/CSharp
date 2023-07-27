using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

/*
날짜 : 2023. 7. 27
이름 : 배성훈
내용 : C#으로 온라인 게임 서버 만들기 (02)
    CUserToken 과 Defines(CMessageResolver에 있다) 정보를 담고 있다!

    Defines : 헤더 
    CUserToken : ?

    CUserToken : CMessageResolver, IMessageDispatcher, ClosedDelegate, CHeartbeatSender 가 필요
*/

namespace Private
{
    public partial class _30_온라인_게임_서버_만들기
    {

        /// <summary>
        /// 헤더 사이즈의 크기를 보관
        /// </summary>
        class Defines
        {

            public static readonly short HEADERSIZE = 4;
        }

        public class CUserToken
        {

            /// <summary>
            /// 토큰 상태
            /// </summary>
            enum State 
            { 
            
                // 대기 중
                Idle,

                // 연결됨
                Connected,

                // 종료가 예약됨
                // sending_list에 대기 중인 상태에서 disconnect를 호출한 경우,
                // 남아있는 패킷을 모두 보낸 뒤 끊도록 하기 위한 상태 값
                ReserveClosing,

                // 소켓이 완전히 종료됨
                Closed,
            }

            // 종료 요청 S -> C
            const short SYS_CLOSE_REQ = 0;

            // 종료 응답 C -> S
            const short SYS_CLOSE_ACK = -1;

            // 하트비트 시작 S -> C
            public const short SYS_START_HEARTBEAT = -2;

            // 하트비트 갱신 C -> S
            public const short SYS_UPDATE_HEARTBEAT = -3;

            // close 중복 처리 방지를 위한 플래그
            // 0 = 연결된 상태
            // 1 = 종료된 상태
            int is_closed;

            State current_state;

            public Socket socket { get; set; }

            public SocketAsyncEventArgs receive_event_args { get; private set; }
            public SocketAsyncEventArgs send_event_args { get; private set; }

            // 바이트를 패킷 형식으로 해석해주는 해석기
            CMessageResolver message_resolver;

            // session 객체
            // 어플리케이션 딴에서 구현하여 사용
            IPeer peer;

            // BufferList 적용을 위해 queue에서 list로 변경
            List<ArraySegment<byte>> sending_list;

            // sending_list lock 처리에 사용되는 객체
            private object cs_sending_queue;

            IMessageDispatcher dispatcher;

            public delegate void CloseDelegate(CUserToken token);
            public ClosedDelegate on_session_closed;

            // heartbeat
            public long latest_heartbeat_time { get; private set; }

            CHeartbeatSender heartbeat_sender;
            bool auto_heartbeat;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="dispatcher"></param>
            public CUserToken(IMessageDispatcher dispatcher)
            {

                this.dispatcher = dispatcher;
                this.cs_sending_queue = new object();

                this.message_resolver = new CMessageResolver();
                this.peer = null;
                this.sending_list = new List<ArraySegment<byte>>();
                this.latest_heartbeat_time = DateTime.Now.Ticks;

                this.current_state = State.Idle;
            }


            /// <summary>
            /// 연결 및 연결에 맞는 상태 변경
            /// </summary>
            public void on_connected()
            {

                this.current_state = State.Connected;
                this.is_closed = 0;
                this.auto_heartbeat = true;
            }

            /// <summary>
            /// peer 등록
            /// </summary>
            /// <param name="peer"></param>
            public void set_peer(IPeer peer)
            {

                this.peer = peer;
            }

            /// <summary>
            /// 수신과 전송 event 등록
            /// </summary>
            /// <param name="receive_event_args"></param>
            /// <param name="send_event_args"></param>
            public void set_event_args(SocketAsyncEventArgs receive_event_args, SocketAsyncEventArgs send_event_args)
            {

                this.receive_event_args = receive_event_args;
                this.send_event_args = send_event_args;
            }


            // CMessageResolver 클래스를 추가하고 다시보기!
            // 역할을 모르겠다. 
            /// <summary>
            /// 이 메소드에서 직접 바이트 데이터를 해석해도 되지만 Message resolver 클래스를 따로 둔 이유는
            /// 추후에 확장성을 고려하여 다른 resolver를 구현할 때 CUserToken 클래스의 코드 수정을 최소화 하기 위함이ㄷㅏ?
            /// 
            /// ????
            /// </summary>
            /// <param name="buffer"></param>
            /// <param name="offset"></param>
            /// <param name="transfered"></param>
            public void on_receive(byte[] buffer, int offset, int transfered)
            {

                this.message_resolver.on_receive(buffer, offset, transfered, on_message_completed);
            }

            /// <summary>
            /// CMessageResolver 보낼 메소드
            /// </summary>
            /// <param name="buffer"></param>
            void on_message_completed(ArraySegment<byte> buffer)
            {

                // peer 가 없으면 탈출
                if (this.peer == null)
                {

                    return;
                }


                if (this.dispatcher != null)
                {

                    // 로직 스레드의 큐를 타고 호출되도록 함
                    this.dispatcher.on_message(this, buffer);
                }
                else
                {

                    // IO 스레드에서 직접 호출
                    CPacket msg = new CPacket(buffer, this);
                    on_message(msg);
                }
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="msg"></param>
            public void on_message(CPacket msg)
            {

                // active close를 위한 코딩
                // 서버에서 종료하라고 연락이 왔는지 체크한다
                // 만약 종료신호가 맞다면 disconnect를 호출하여 받은쪽에서 먼저 종료 요청을 보낸다
                switch (msg.protocol_id)
                {

                    // 종료 요청
                    case SYS_CLOSE_REQ:
                        disconnect();
                        return;

                    // 하트비트 시작 요청
                    case SYS_START_HEARTBEAT:
                        {

                            // 순서대로 파싱해야 하므로 프로토콜 아이디는 버린다
                            msg.pop_protocol_id();

                            byte interval = msg.pop_byte();
                            this.heartbeat_sender = new CHearbeatSender(this, interval);

                            if (this.auto_heartbeat)
                            {

                                start_heartbeat();
                            }
                        }
                        return;

                    // 하트비트 업데이트 요청
                    case SYS_UPDATE_HEARTBEAT:
                        this.latest_heartbeat_time = DateTime.Now.Ticks;
                        return;
                }

                // peer가 등록되어져 잇는 경우
                if (this.peer != null)
                {

                    try
                    {

                        // protocol id 분석
                        switch (msg.protocol_id)
                        {

                            // ?
                            case SYS_CLOSE_ACK:
                                this.peer.on_removed();
                                break;

                            // ?
                            default:
                                this.peer.on_message();
                                break;
                        }
                    }
                    catch (Exception)   // 에러 발생
                    {

                        close();
                    }
                }

                // ACK 의미 찾아봐야한다
                if (msg.protocol_id == SYS_CLOSE_ACK)
                {

                    // session_closed 가 비어져 있으면 지금 토큰의 세션 추가
                    if (this.on_session_closed != null)
                    {

                        this.on_session_closed(this);
                    }
                }
            }

            /// <summary>
            /// ?
            /// </summary>
            public void close()
            {

                // 중복 수행을 막는다
                if (Interlocked.CompareExchange(ref this.is_closed, 1, 0) == 1)
                {

                    return;
                }

                if (this.current_state == State.Closed)
                {

                    return;
                }

                this.current_state = State.Closed;
                this.socket.Close();
                this.socket = null;

                this.send_event_args.UserToken = null;
                this.receive_event_args.UserToken = null;

                this.sending_list.Clear();
                this.message_resolver.clear_buffer();

                if (this.peer != null)
                {

                    CPacket msg = CPacket.create((short)-1);
                    if (this.dispatcher != null)
                    {

                        this.dispatcher.on_message(this, new ArraySegment<byte>(msg.buffer, 0, msg.position));
                    }
                    else
                    {

                        on_message(msg);
                    }
                }
            }

            /// <summary>
            /// 패킷을 전송한다
            /// 큐가 비어있을 경우에는 큐에 추가한 뒤에 바로 SendAsync 메소드를 호출하고,
            /// 데이터가 들어있을 경우에는 새로 추가만 한다
            /// 
            /// 큐된 패킷의 전송 시점 :
            ///     현재 진행 중인 SendAsync가 완료되었을 때 큐를 검사하여 나머지 패킷을 전송한다
            /// </summary>
            /// <param name="data"></param>
            public void send(ArraySegment<byte> data)
            {

                lock (this.cs_sending_queue)
                {

                    this.sending_list.Add(data);

                    if (this.sending_list.Count > 1)
                    {

                        // 큐에 무언가가 들어 있다면 아직 전송이 완료되지 않은 상태이므로 큐에 추가만하고 리턴한다
                        // 현재 수행 중인 SendAsync가 완료된 이후에 큐를 검사하여 데이터가 있으면 SendAsync를 호출하여 전송해 줄 것이다
                        return;
                    }
                }

                start_send();
            }

            public void send(CPacket msg)
            {

                // 사이즈 입력
                msg.record_size();
                // 데이터 전달
                send(new ArraySegment<byte>(msg.buffer, 0, msg.position));
            }

            /// <summary>
            /// 비동기 전송을 시작한다
            /// </summary>
            void start_send()
            {

                try
                {

                    // 성능 향상을 위해 SetBuffer에서 BufferList를 사용하는 방식으로 변경함
                    this.send_event_args.BufferList = this.sending_list;

                    // 비동기 전송 시작
                    bool pending = this.socket.SendAsync(this.send_event_args);
                    if (!pending)
                    {

                        process_send(this.send_event_args);
                    }
                }
                catch (Exception e)
                {

                    if (this.socket == null)
                    {

                        close();
                        return;
                    }

                    Console.WriteLine("send error!! close socket. " + e.Message);
                    throw new Exception(e.Message, e);
                }
            }

            static int sent_count = 0;
            static object cs_count = new object();

            /// <summary>
            /// 비동기 전송 완료 시 호출되는 콜백 메소드
            /// </summary>
            /// <param name="e"></param>
            public void process_send(SocketAsyncEventArgs e)
            {

                if (e.BytesTransferred <= 0 || e.SocketError != SocketError.Success)
                {

                    // 연결이 끊겨서 이미 소켓이 종료된 경우일 것이다
                    return;
                }

                lock (this.cs_sending_queue)
                {

                    // 리스트에 들어있는 데이터의 총 바이트 수
                    var size = this.sending_list.Sum(obj => obj.Count);

                    // 전송이 완료되기 전에 추가 전송을 요청했다면 sending_list에 무언가 더 들어있을 것이다
                    if (e.BytesTransferred != size)
                    {

                        if (e.BytesTransferred < this.sending_list[0].Count)
                        {

                            string error = $"Need to send more! transferred {e.BytesTransferred}, packet size {size}";
                            Console.WriteLine(error);

                            close();

                            return;
                        }

                        // 보낸 만큼 빼고 나머지 대기 중인 데이터들을 한방에 보내버린다
                        int sent_index = 0;
                        int sum = 0;
                        for (int i = 0; i < this.sending_list.Count; ++i)
                        {

                            sum += this.sending_list[i].Count;
                            if (sum <= e.BytesTransferred)
                            {

                                // 여기 까지는 전송 완료된 데이터 인덱스
                                sent_index = i;
                                continue;
                            }

                            break;
                        }

                        // 전송 완료된 것은 리스트에서 삭제한다
                        this.sending_list.RemoveRange(0, sent_index + 1);

                        // 나머지 데이터들을 한방에 보낸다
                        start_send();
                        return;
                    }

                    // 다 보냈고 더이상 보낼 것도 없다
                    this.sending_list.Clear();

                    // 종료가 예약된 경우, 보낼건 다 보냈으니 진짜 종료 처리를 진행한다
                    if (this.current_state == State.ReserveClosing)
                    {

                        this.socket.Shutdown(SocketShutdown.Send);
                    }
                }
            }

            public void disconnect()
            {

                try
                {

                    if (this.sending_list.Count <= 0)
                    {

                        this.socket.Shutdown(SocketShutdown.Send);
                        return;
                    }

                    this.current_state = State.ReserveClosing;
                }
                catch (Exception)
                {

                    close();
                }
            }

            public void ban()
            {

                try
                {

                    byebye();
                }
                catch (Exception)
                {

                    close();
                }
            }

            void byebye()
            {

                CPacket bye = CPacket.create(SYS_CLOSE_REQ);
                send(bye);
            }

            public bool is_connected()
            {

                return this.current_state == State.Connected;
            }

            public void start_heartbeat()
            {

                if (this.heartbeat_sender != null)
                {

                    this.heartbeat_sender.play();
                }
            }

            public void stop_heartbeat()
            {

                if (this.heartbeat_sender != null)
                {

                    this.heartbeat_sender.stop();
                }
            }

            public void disable_auto_heartbeat()
            {

                stop_heartbeat();
                this.auto_heartbeat = false;
            }

            public void update_heartbeat_manually(float time)
            {

                if (this.heartbeat_sender != null)
                {

                    this.heartbeat_sender.update(time);
                }
        }
    }
}
