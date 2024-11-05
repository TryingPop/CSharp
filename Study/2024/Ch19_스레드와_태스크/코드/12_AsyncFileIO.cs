using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 5
이름 : 배성훈
내용 : .NET이 제공하는 비동기 API 맛보기
    교재 p 694 ~ 

    C# 언어가 비동기 프로그래밍 패러다임을 지원하도록 만드는 한편 .NET도 기존 API에 더불어 비동기 버전 API를 새롭게 제공하도록 업그레이드 했다.
    .NET 라이브러리 곳곳에 추가된 ~Async() 함수들이 대표적인 예이다.
*/

namespace Study._2024.Ch19_스레드와_태스크.코드
{
    internal class _12_AsyncFileIO
    {

        static async Task<long> CopyAsync(string FromPath, string ToPath)
        {

            using (var fromStream = new FileStream(FromPath, FileMode.Open))
            {

                long totalCopied = 0;

                using (var toStream = new FileStream(ToPath, FileMode.Create))
                {

                    byte[] buffer = new byte[1024];
                    int nRead = 0;
                    // fromStream으로부터 buffer.Lenth만큼 읽어와서 buffer에 0번부터 저장하라는 말이다.
                    // 읽은 크기를 반환
                    while((nRead = 
                        await fromStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {

                        // 읽은걸 toPath에 복사하는 코드
                        await toStream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead;
                    }
                }

                return totalCopied;
            }
        }

        static async void DoCopy(string FromPath, string ToPath)
        {

            long totalCopied = await CopyAsync(FromPath, ToPath);
            Console.WriteLine($"Copied Total {totalCopied} Bytes.");
        }

        static void Main12(string[] args)
        {

            string fromPath = "";
            string toPath = "";
            DoCopy(fromPath, toPath);

            Console.ReadLine();
        }
    }
}
