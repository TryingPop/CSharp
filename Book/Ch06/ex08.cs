using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 6-8
 * 
 * 클래스 메서드에서 인스턴스 변수 사용은 오류가 발생
 */

namespace Book.Ch06
{
    internal class ex08
    {
        public int instanceVariable = 10;

        static void Main8(string[] args)
        {
            // 사용불가능
            // Console.WriteLine(instanceVriable);
            // 쓸러면 static 붙여서 정의하기
            // static은 메모리에 올라간다.
            
            // 아래처럼 클래스를 불러와야 메모리에 저장된다
            ex08 ex = new ex08();
            Console.WriteLine(ex.instanceVariable); 
        }
    }
}
