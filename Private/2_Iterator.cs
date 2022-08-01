using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.29
 * 내용 : 반복자, 반복기(Iterator) - yield return
 */

// 클래스의 상위 Scope
// 중복된 이름의 클래스를 구분하기 위해서 사용
namespace Private
{
    internal class _2_Iterator
    {
        static void Main2(string[] args)
        {
            // F11로 실행해서 보면 
            // output에 0~ 9의 모든 값이 담긴게 아니라
            // 0 ~ 9 의 값을 하나씩 가져오는 행동을 반복!
            var output = GetNumber();

            foreach (int num in output)
            {
                Console.WriteLine(num);
            }

            
        }
        // 변수에 out, ref는 사용 불가능
        static IEnumerable<int> GetNumber()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }

        delegate IEnumerable<int> D();
        IEnumerable<int> GetEnumerator() 
        {
            try
            {
                yield return 1;
                yield break;
            }
            finally
            {
                // finally 절에는 yield return, yield break 구문 사용 불가능
                // yield return 2; 
                // yield break;
            }

            try
            {
             // yield return 1; // try - catch 구문에서 yield return 구문 사용 불가능
                yield break;
            }
            catch
            {
             //   yield return 3; // try - catch 구문에서 yield return 구문 사용 불가능
                yield break;
            }
            /*
            D d = 
            {
                // 익명 메서드에서 yield 구문 사용 불가능
                yield return 5; 
                yield break;
            }
            */
        }
    }
}


// 참고 사이트
// https://m.blog.naver.com/PostView.naver?isHttpsRedirect=true&blogId=netscout82&logNo=20120602703 
// https://m.blog.naver.com/netscout82/20120661670



// 반복자의 모든 지역 변수는 변환과정에서 생성되는 상태 기계 클래스의 멤버 변수
// 그리고 상태 기계 클래스는 어디까지 실행되고 멈췄는지를 기록하는 state 멤버를 추가적으로 가지게 되며
// 최근에 요청된 값을 가지게되는 current 멤버도 가지게 된다.

/*
class MyClass
{
    public IEnumerable<int> GetNumbers()
    {
        for (int i = 0; i <= 10; i+= 2)
        {
            yield return i;
        }
    }
}

// 이 반복자를 컴파일해서 생성되는 코드를 리플렉터로 보면

internal class MyClass
{
    public MyClass();
    public IEnumerable<int> GetNumber();

    [CompilerGenerated]
    private sealed class <GetNumbers>d__0 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
    {
        private int <>1__state; // 상태 값
        private int <>2__current; // 현재 값
        public MyClass <>4__this; // 자동생성된 클래스이고 myclass의 this가 <>4__this가 됨
        private int <>I__initialThreadld; // 이 반복자를 사용하는 Thread ID
        public int <i>5__1; // for문의 반복변수 i

        // Method
        [DebuggerHidden]
        public <GetNumber>d__0(int <>1__state)
        {
            this.<>1__state = <>1__state;
            this.<>l__initialThreadld = Thread.CurrentThread.MeanagedThreadld;
        }
        
        private bool MoveNext()
        {
            switch (this.<>1__state) // state 값 체크
            {
                case 0: 
                    this.<>1__state = -1;
                    this.<i>5__1 = 0;
                    while (this.<i>5__1 <= 10)
                    {
                        this.<>2__current = this.<i>5__1;
                        this.<>1__state = 1;

                        return true;
                    Label_0046:
                        this.<>1__state = -1;
                        this.<i>5__1 += 2;
                    }
                    break;
                    }
                case 1:
                    goto Label_0046;

            }
            return false;
        }

        [DebuggerHidden]
        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            if ((Thread.CurrentThread.ManagedThreadld == this.<>l__InitialThreadld) && (this.<>1__state == -2))
            {
                this.<>1__state = 0;
                return this; // 자기 자신을 리턴
            }
            MyClass.<GetNumbers>d__0 d__ = new MyClass.<GetNumbers>d__0(0);
            d__.<>4__this = this.<>4__this;
            return d__;

        }
 */

// 값형 : stack에 할당될 수 있다.
// 참조형 : heap에 할당된다.
// 가비지 컬렉션은 메모리에 표시, 청소, 압축 
// 메모리에 있는 객체를 참조 카운터 부여(표시)
// 참조 카운터가 0인것을 제거(청소)
// 이때 메모리에 빈 공간이 나오는데 빈 공간을 하나의 단일한 공간으로 구성하게 한다(압축)
// 압축에서 포인터를 이리저리 움직인다.
// 이 작업이 여러 번에 걸쳐서 수행될 수 있다
// 또한 참조카운터가 적고 많은것 끼리 구분
// 전부 검사하는건 안하고 수명이 짧은거 위주로 검사한다
// 보통 기준이
// 새로운 객체일수록 수명이 짧을것
// 더 오래된 객체일수록 수명이 길것
// 새로운 객체들끼리 서로 긴밀한 관계에 있으며 거의 동일한 시간에 엑세스된다
// 힙의 일부분을 압축하는 것이 전체 힙을 압축하는 것보다 빠르다

// 스텍은 바닥에 있는 것이 더 오래살 것이다
// 금방 사라질 것은 위쪽에 위치해서
// 빈공간의 목록 유지, 표시, 청소하기도 필요없다
// 스택에선 메모리 할당은 포인터가 이동하는 것으로 끝!

// 그래서 힙이랑 스텍에 메모리 할당을 비교하면
// 스택에 메모리 할당이 빠를거라 생각하지만
// 실제론 거의 동일하다
// 메모리 해제에 수행해야하는 작업 차이 때문에 발생하는 성능이 문제

// 이 때문에 
// 값 형의 지역변수와 형식 파라미터가 좋은 예
// 클래스의 지역변수가 당연히 메서드의 지역변수보다 오래 살아남는다
// 형식 파라미터 역시 메서드의 종료와 함께 사라진다
// 값형은 값으로 복사되고 참조는 복사 안된다
// 참조형의 경우 메모리의 값을 여러 변수가 동시에 참조할 수 있는 반면 
// 값형의 경우에는 메모리의 값을 참조할 수 있는 것은 자신 뿐
// 객체의 생사를 파악하는데 참조를 주목할 필요 X
// 지역변수의 참조를 가져오는 방법은 참조 스택의 맨 위로 올라가도록
// ref나 out 파라미터로 넘겨주는 방법 외에는 없다
// 지역 변수는 메서드가 종료되어도 살아남을 것이 없기 때문에 지역변수의 참조가
// 스택의 맨 위에 있다고해도 상관 없기 때문에

// 만약 참조형이 이터레이터 변수에 올라오면
// 수명이 긴 애가 참조해버리면
// 수명이 긴 애가 죽기전에 제거 불가능
// 만약 제거되면 예기치 못하는 버그 발생
// 살아 있따면 스텍에서 갖는 메모리의 장점이 사라진다

// 마찬가지로 익명 메서드와 반복자에서 ref, out 형식의 파라미터는 사용 불가능하다
