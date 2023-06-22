/*
날짜 : 2023. 6. 23
이름 : 배성훈
내용 : visual studio에서 콘솔을 다루는 법
    \r이 갖는 의미, 현재 커서의 위치, 위로 한칸 이동하는 방법
    그리고 라인을 지우는 방법이 있다

    입력한 문자열을 저장하는 코드만 있으면 콘솔로 채팅 구현이 가능할거 같다
*/

namespace Private
{
    internal class _28_Consolel
    {

        static void Main(string[] args)
        {

            // 특수 문자 \r (개행)
            Console.Write("012345\r111");               // 111345 이 출력되고 커서의 위치는 문자 3에 위치한다
                                                        // \r의 역할 개행은 현재 행에서 왼쪽 끝으로 이동한다
                                                        // 그리고 콘솔창에서는 해당 위치에 문자열을 입력하면
                                                        // 덮어쓴다
            
            Console.Write("ㅎㅇ");                     
            Console.WriteLine(Console.CursorLeft);      // 콘솔 현재 입력 x(좌우)좌표가 어디인지 알려준다
                                                        // 시작점은 0이고 왼쪽에 문자열이 몇 개인지 판별하기에 용이하다
                                                        // 한글은 2칸 차지하므로 4가 출력된다
            Console.WriteLine(Console.CursorTop);       // 위에서 몇번째인지 확인
                                                        // 마찬가지로 0이 출력된다
            
            // 라인 지우는 법
            string s = "\r";                            // 먼저 커서의 맨처음 위치로 이동하는 커맨더
            s += new string(' ', Console.CursorLeft);   // 왼쪽의 문자열만큼 공백으로 덮어쓴다
            s += "\r";                                  // 그리고 다시 커서를 처음 위치로 이동
            Console.Write(s);                           // 이제 이 문자열을 출력해주면 라인을 지우는 코드가 된다

            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 2);   // 위로 1칸 이동하는 커맨더이다
            
            Console.ReadKey();
        }
    }
}
