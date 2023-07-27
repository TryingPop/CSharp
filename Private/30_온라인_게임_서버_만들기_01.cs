using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 7. 27
이름 : 배성훈
내용 : C#으로 온라인 게임 서버 만들기 (01)
    한빛 미디어에서 출판한 책이다
    여기에 사용된 코드를 분석하는 클래스

    일단 저자의 소스코드를 여러 파트로 나눠서 그대로 따라 쳐본다
    ---- 이후에는 윗글 생략! ----

    여기서는 IPeer, CPacket을 작성한다

    IPeer 인터페이스는 서버와 클라이언트 공통으로 작성되는 객체이다
    메소드 이름으로 봐서 메세지를 보내고 연결을 담당하는 인터페이스로 보인다

    CPacket 전송하는 데이터를 포멧시킨 형태같이 보인다

    필요한 클래스 
        IPeer : CPacket
        CPacket : CUserToken, Defines
*/

namespace Private
{
    public partial class _30_온라인_게임_서버_만들기
    {

        /// <summary>
        /// 서버와 클라이언트에서 공통으로 사용되는 세션 객체
        /// 
        /// 서버의 경우 :
        ///     하나의 클라이언트 객체를 나타낸다
        ///     이 인터페이스를 구현한 객체를 CNetworkService 클래스의 session_create_callback 호출 시 생성하여 리턴시켜 준다
        ///     객체를 풀링할지 여부는 사용자가 원하는대로 구현한다
        /// 
        /// 클라이언트일 경우 :
        ///     접속한 서버 객체를 나타낸다
        /// </summary>
        public interface IPeer
        {

            // 주석 처리된 코드
            // void on_message(ArraySegment<byte> buffer);

            // void process_user_operation(CPacket msg);

            /// <summary>
            /// CNetworkService.initialize에서 use_logicthread를 true로 설정할 경우
            /// -> IO스레드에서 직접 호출됨
            /// 
            /// false로 설정할 경우
            /// -> 로직 스레드에서 호출됨 
            ///     로직 스레드는 싱글 스레드로 돌아감
            /// </summary>
            /// <param name="msg"></param>
            void on_message(CPacket msg);

            /// <summary>
            /// 원격 연결이 끊겼을 때 호출된다
            /// 이 메소드가 호출된 이후부터는 데이터 전송이 불가능하다
            /// </summary>
            void on_removed();

            void send(CPacket msg);

            void disconnect();
        }

        public class CPacket
        {

            public CUserToken owner { get; private set; }
            public byte[] buffer { get; private set; }
            public int position { get; private set; }
            public int size { get; private set; }
            public Int16 protocol_id { get; private set; }      // Int16 = short ( 2바이트 정수형 자료변수)

            /// <summary>
            /// CPacket 생성
            /// </summary>
            /// <param name="protocol_id"></param>
            /// <returns></returns>
            public static CPacket create(Int16 protocol_id)
            {

                CPacket packet = new CPacket();

                // 주석도 따라쳤는데 의미가?
                // todo: 다음 리팩토링 대상은 바로 여기이다 CPacketBufferManager?
                // CPacket packet = CPacketBufferManager.pop();

                packet.set_protocol(protocol_id);

                return packet;
            }

            /// <summary>
            /// 내용 없다
            /// </summary>
            /// <param name="packet"></param>
            public static void destroy(CPacket packet)
            {

                // CPacketBufferManager.push(packet);
            }

            // ArraySegment는 배열의 부분을 가져오는 것이다
            // 일종의 슬라이싱!
            public CPacket(ArraySegment<byte> buffer, CUserToken owner)
            {

                // 참조로만 보관하여 작업한다
                // 복사가 필요하면 별도로 구현해야 한다
                this.buffer = buffer.Array;

                // 헤더는 읽을 필요 없으니 그 이후부터 시작한다
                this.position = Defines.HEADERSIZE;
                this.size = buffer.Count;

                // 프로토콜 아이디만 확일할 경우도 있으므로 미리 뽑아 놓는다
                this.protocol_id = pop_protocol_id();
                this.position = Defines.HEADERSIZE;

                this.owner = owner;
            }

            public CPacket()
            {

                this.buffer = new byte[1024];
            }

            /// <summary>
            /// 2바이트로 저장된 pop_protocol_id 읽기
            /// 맨 앞에 2바이트가 protocol_id 같다
            /// </summary>
            /// <returns></returns>
            public Int16 pop_protocol_id()
            {

                return pop_int16();
            }

            public void copy_to(CPacket target)
            {

                target.set_protocol(this.protocol_id);
                target.overwrite(this.buffer, this.position);
            }

            /// <summary>
            /// 대상이 배열을 해당 위치부터 끝까지 복사해서 
            /// 내부 변수인 buffer에 담는다
            /// 또한 내부 변수 position에 위치 정보를 담는다
            /// </summary>
            /// <param name="source">복사할 배열</param>
            /// <param name="position">복사 시작 지점</param>
            public void overwrite(byte[] source, int position)
            {

                Array.Copy(source, this.buffer, source.Length);
                this.position = position;
            }

            /// <summary>
            /// 버퍼에 있는 현재 위치 값 출력
            /// </summary>
            /// <returns></returns>
            public byte pop_byte()
            {

                byte data = this.buffer[this.position];
                this.position += sizeof(byte);
                return data;
            }

            /// <summary>
            /// 현재 버퍼의 위치 값 short로 읽기
            /// </summary>
            /// <returns>short 값</returns>
            public Int16 pop_int16()
            {

                Int16 data = BitConverter.ToInt16(this.buffer, this.position);
                this.position += sizeof(Int16);
                return data;
            }

            /// <summary>
            /// 버퍼의 현 위치 값 int로 읽기
            /// </summary>
            /// <returns>int 값</returns>
            public Int32 pop_int32()
            {

                Int32 data = BitConverter.ToInt32(this.buffer, this.position);
                this.position += sizeof(Int32);
                return data;
            }

            /// <summary>
            /// 문자열 읽기
            /// 문자열 앞에는 문자열 길이 정보가 있다!
            /// 문자열은 UTF8형식
            /// </summary>
            /// <returns>읽은 문자열</returns>
            public string pop_string()
            {

                // 문자열 길이는 최대 2바이트 까지 0 ~32767
                Int16 len = BitConverter.ToInt16(this.buffer, this.position);
                this.position += sizeof(Int16);

                // 인코딩은 utf8로 통일
                string data = System.Text.Encoding.UTF8.GetString(this.buffer, this.position, len);
                this.position += len;

                return data;
            }

            /// <summary>
            /// 현재 위치의 버퍼의 값 float으로 읽기
            /// </summary>
            /// <returns>읽은 float 값</returns>
            public float pop_float()
            {

                float data = BitConverter.ToSingle(this.buffer, this.position);     // Single은 float의 다른 이름이라 보면 된다
                this.position += sizeof(float);
                return data;
            }

            /// <summary>
            /// 프로토콜 넣는다
            /// </summary>
            /// <param name="protocol_id"></param>
            public void set_protocol(Int16 protocol_id)
            {

                this.protocol_id = protocol_id;

                // this.buffer = new byte[1024];

                // 헤더는 나중에 넣을 것이므로 데이터 부터 넣을 수 있도록 위치를 점프 시켜 놓는다
                this.position = Defines.HEADERSIZE;

                push_int16(protocol_id);
            }

            /// <summary>
            /// header + body 를 합한 사이즈를 입력
            /// </summary>
            public void record_size()
            {

                byte[] header = BitConverter.GetBytes(this.position);
                header.CopyTo(this.buffer, 0);
            }

            // 밑에 같은 기능을 하는 push 함수가 있지만
            // 프로토콜 id 부분을 강조하기 위해 정의해서 사용하는거 같다
            /// <summary>
            /// Int16 데이터를 버퍼에 추가한다
            /// </summary>
            /// <param name="data">추가할 데이터</param>
            public void push_int16(Int16 data)
            {

                byte[] temp_buffer = BitConverter.GetBytes(data);
                temp_buffer.CopyTo(this.buffer, this.position);
                this.position += temp_buffer.Length;
            }

            /// <summary>
            /// 바이트 데이터를 버퍼에 추가
            /// </summary>
            /// <param name="data">추가할 데이터</param>
            public void push(byte data)
            {

                byte[] temp_buffer = BitConverter.GetBytes(data);
                temp_buffer.CopyTo(this.buffer, this.position);
                this.position += sizeof(byte);
            }

            /// <summary>
            /// short 데이터를 버퍼에 추가한다
            /// </summary>
            /// <param name="data">추가할 데이터</param>
            public void push(Int16 data)
            {

                byte[] temp_buffer = BitConverter.GetBytes(data);
                temp_buffer.CopyTo(this.buffer, this.position);
                this.position += temp_buffer.Length;
            }

            /// <summary>
            /// int 변수를 버퍼에 추가한다
            /// </summary>
            /// <param name="data">추가할 데이터</param>
            public void push(Int32 data)
            {

                byte[] temp_buffer = BitConverter.GetBytes(data);
                temp_buffer.CopyTo(this.buffer, this.position);
                this.position += temp_buffer.Length;
            }

            /// <summary>
            /// 문자열을 버퍼에 추가한다
            /// </summary>
            /// <param name="data">추가할 데이터</param>
            public void push(string data)
            {

                // 문자열을 UTF8 형식으로 일코딩해 temp_buffer에 저장
                byte[] temp_buffer = System.Text.Encoding.UTF8.GetBytes(data);

                // 문자열의 길이 확인
                Int16 len = (Int16)temp_buffer.Length;
                // 문자열의 길이를 byte[] 형식으로 저장
                byte[] len_buffer = BitConverter.GetBytes(len);

                // 문자열의 길이를 먼저 버퍼에 넣는다
                len_buffer.CopyTo(this.buffer, this.position);
                this.position += sizeof(Int16);

                // 이후에 문자열을 버퍼에 넣는다
                temp_buffer.CopyTo(this.buffer, this.position);
                this.position += temp_buffer.Length;
            }

            /// <summary>
            /// 실수형 데이터를 버퍼에 넣는다
            /// </summary>
            /// <param name="data">추가할 데이터</param>
            public void push(float data)
            {

                byte[] temp_buffer = BitConverter.GetBytes(data);
                temp_buffer.CopyTo(this.buffer, this.position);
                this.position += temp_buffer.Length;
            }
        }
    }
}

// 참고할 사이트 
// https://github.com/sunduk/FreeNet
// 책의 설명이 중간에 누락된게 너무 많아서 깃으로 확인하기!

// 이후에는 다음 코드 확인하자!
// https://www.codeproject.com/Articles/83102/C-SocketAsyncEventArgs-High-Performance-Socket-Cod