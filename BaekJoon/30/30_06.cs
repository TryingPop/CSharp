using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 12. 19
이름 : 배성훈
내용 : 앱
    문제번호 : 7579번

    입력 
    5 60            // 실행 중인 파일 수, 확보해야하는 메모리
    30 10 20 35 40  // 활성화 때 소모하는 메모리 
    3 0 3 5 4       // 종료할 때 필요한 메모리

    // 필요메모리를 확보함에 있어 종료할 때 메모리를 최소화하는 

    최저는 이라한다
    30 + 10 + 20 >= 60
    3 + 0 + 3 = 6

    찾는 방법 1
    일단 메모리 부터 맞춰서? 

    음? 동적 계획법인 만큼 메모리를 저장 해야할거 같다

    일단 for문 돌면서 ? cost 값이 최소일 때 맥스 값 찾을까?
    
*/

namespace BaekJoon._30
{
    internal class _30_06
    {

        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int[] info = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] memActive = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] memInActive = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

            sr.Close();

            // dp 연산

        }
    }
}
