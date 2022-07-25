using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-11
 * 
 * Object 클래스의 선언
 */

namespace Book.Ch07
{
    internal class ex11
    {
        // C#에서 클래스를 만들면 object라는 클래스의 상속을 받는다
        // object로 가보면 다음과 같고 모든 클래스는 아래를 상속받게 된다
        /*
        class Object 
        {
            public Object();

            public virtual bool Equals(object obj);
            public static bool Equals(object objA, object objB);
            public virtual int GetHashCode();
            public Type GetType();
            protected object MemberwiseClone();
            public static bool ReferenceEquals(object objA, object objB);
            public virtual string ToString();
        }
        */
    }
}
