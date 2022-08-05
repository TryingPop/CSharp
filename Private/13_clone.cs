using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private
{
    internal class _13_clone
    {
        static void Main13(string[] args)
        {
            byte[] arr1 = { 1, 2, 3 };
            // 얕은 복사 : 주소값 복사
            byte[] arr2 = arr1;
            // 깊은 복사 : 새로 생성
            byte[] arr3 = { 1, 2, 3 };
            // 깊은 복사
            byte[] copy = arr1.Clone() as byte[];

            arr1[0] = (byte)4;
            Console.WriteLine(copy[0]); 
        }
    }
}
