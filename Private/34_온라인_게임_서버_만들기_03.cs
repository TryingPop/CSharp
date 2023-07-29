using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 7. 30
이름 : 배성훈
내용 : C#으로 온라인 게임 서버 만들기 (03)
    CMessageResolver, IMessageDispatcher

    일단 한 번 똑같이 작성해보고 ! 
    다시 분석하자... 
*/

namespace Private
{
    public partial class _30_온라인_게임_서버_만들기
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        public delegate void CompletedMessageCallback(ArraySegment<byte> buffer);

        public class CMessageResolver
        {

            // 메시지 사이즈
            int message_size;

            // 진행 중인 버퍼
            byte[] message_buffer = new byte[1024];

            // 현재 진행 중인 버퍼의 인덱스를 가리키는 변수
            // 패킷 하나를 완성한 뒤에는 0으로 초기화 시켜줘야 한다
            int current_position;

            // 읽어와야 할 목표 위치
            int position_to_read;

            // 남은 사이즈
            int remain_bytes;

            public CMessageResolver()
            {

                this.message_size = 0;
                this.current_position = 0;
                this.position_to_read = 0;
                this.remain_bytes = 0;
            }

            /// <summary>
            /// 목표지점으로 설정된 위치까지의 바이트를 원본 버퍼로부터 복사한다
            /// 데이터가 모자랄 경우 현재 남은 바이트 까지만 복사한다
            /// </summary>
            /// <param name="buffer"></param>
            /// <param name="src_position">다 읽었으면 true, 데이터가 모자라서 못 읽었으면 false를 리턴한다</param>
            /// <returns></returns>
            bool read_until(byte[] buffer, ref int src_position)
            {

                // 읽어와야 할 바이트
                // 데이터가 분리되어 올 경우 이전에 읽어놓은 값을 빼줘서 부족한 만큼 읽어올 수 있도록 계산해 준다
                int copy_size = this.position_to_read - this.current_position;

                // 남은 데이터가 더 적다면 가능한 만큼만 복사한다
                if (this.remain_bytes < copy_size)
                {

                    copy_size = this.remain_bytes;
                }

                // 버퍼에 복사
                Array.Copy(buffer, src_position, this.message_buffer, this.current_position, copy_size);

                // 원본 버퍼 포지션 이동
                src_position += copy_size;

                // 타겟 버퍼 포지션도 이동
                this.current_position += copy_size;

                // 남은 바이트 수
                this.remain_bytes -= copy_size;

                // 목표 지점에 도달 못했으면 false
                if (this.current_position < this.position_to_read)
                {

                    return false;
                }

                return true;
            }

            /// <summary>
            /// 소켓 버퍼로부터 데이터를 수신할 때마다 호출된다
            /// 데이터가 남아 있을 때까지 계속 패킷을 만들어 callback을 호출해 준다
            /// 하나의 패킷을 완성하지 못했다면 버퍼에 보관해 놓은 뒤 다음 수신을 기다린다
            /// </summary>
            /// <param name="buffer"></param>
            /// <param name="offset"></param>
            /// <param name="transffered"></param>
            /// <param name="callback"></param>
            public void on_receive(byte[] buffer, int offset, int transffered, CompletedMessageCallback callback)
            {

                // 이번 receive로 읽어오게 될 바이트 수
                this.remain_bytes = transffered;

                // 원본 버퍼의 포지션 값
                // 패킷이 여러개 뭉쳐 올 경우 원본 버퍼의 포지션은 계속 앞으로 가야 하는데 그 처리를 위한 변수이다
                int src_position = offset;

                // 남은 데이터가 있다면 계속 반복한다
                while(this.remain_bytes > 0)
                {

                    bool completed = false;

                    // 헤더만큼 못 읽은 경우 헤더를 먼저 읽는다
                    if (this.current_position < Defines.HEADERSIZE)
                    {

                        // 목표 지점 설정(헤더 위치까지 도달하도록 설정)
                        this.position_to_read = Defines.HEADERSIZE;

                        completed = read_until(buffer, ref src_position);

                        if (!completed)
                        {

                            // 아직 다 못 읽었으므로 다음 receive를 기다린다
                            return;
                        }

                        // 헤더 하나를 온전히 읽어왔으므로 메시지 사이즈를 구한다
                        this.message_size = get_total_message_size();

                        // 메시지 사이즈가 0 이하라면 잘못된 패킷으로 처리한다
                        if (this.message_size <= 0)
                        {

                            clear_buffer();
                            return;
                        }

                        // 다음 목표 지점
                        this.position_to_read = this.message_size;

                        // 헤더를 다 읽었는데 더 이상 가져올 데이터가 없다면 다음 receive를 기다린다
                        // 예를들어 데이터가 조각나서 헤더만 오고 메시지는 다음번에 올 경우
                        if (this.remain_bytes <= 0)
                        {

                            return;
                        }
                    }

                    // 메시지를 읽는다
                    completed = read_until(buffer, ref src_position);

                    if (completed)
                    {

                        // 패킷 하나를 완성 했다
                        byte[] clone = new byte[this.position_to_read];
                        Array.Copy(this.message_buffer, clone, this.position_to_read);
                        clear_buffer();
                        callback(new ArraySegment<byte>(clone, 0, this.position_to_read));
                    }
                }
            }

            /// <summary>
            /// 헤더 + 바디 사이즈를 구한다
            /// 패킷 헤더 부분에서 이미 전체 메시지 사이즈가 계산되어 있으므로 헤더 크기에 맞게 변환만 시켜주면 된다
            /// </summary>
            /// <returns></returns>
            int get_total_message_size()
            {

                if (Defines.HEADERSIZE == 2)
                {

                    return BitConverter.ToInt16(this.message_buffer, 0);
                }
                else if (Defines.HEADERSIZE == 4)
                {

                    return BitConverter.ToInt32(this.message_buffer, 0);
                }

                return 0;
            }

            /// <summary>
            /// Array 메서드를 이용해 0값으로 초기화 (memset과 같다)
            /// </summary>
            public void clear_buffer()
            {

                Array.Clear(this.message_buffer, 0, this.message_buffer.Length);

                this.current_position = 0;
                this.message_size = 0;
            }
        }


        public interface IMessageDispatcher
        {

            void on_message(CUserToken user, ArraySegment<byte> buffer);
        }
    }
}
