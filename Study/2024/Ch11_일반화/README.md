# Ch11 일반화
## 일반화 프로그래밍
특수한 개념으로부터 공통된 개념을 찾아 묶는 것을 일반화(Generalization)라고 한다.<br/>
일반화 프로그래밍(Generic Programming)은 이러한 일반화를 이용하는 프로그래밍 기법이다.<br/>
일반화하는 대상은 데이터 형식(Data Type)이다.<br/>


## 일반화 메소드
일반화 메소드(Generic Method)는 데이터 형식을 일반화한 메소드다.<br/>
일반화할 형식이 들어갈 자리에 구체적인 형식의 이름 대신 형식 매개변수(Type Parameter)가 들어간다.<br/>


	// 형식
	한정자 반환_형식 메소드_이름<형식_매개변수> ( 매개변수_목록 )
	{
	
	    // ...
	}
	
	// 예제
	T Add<T> (T _f, T _b)
	{
	
	    // ...
	    // T ret = _f + _b;	// 형식을 모르므로 사용 불가능
	    return _f;
	}


예제의 T는 C#이 지원하는 형식이 아니다. 여기서는 형식 매개변수(Type Parameter)로 쓰인 변수로 보면 된다.<br/>
T자리에 형식을 입력하면 CIL(공용 중간언어) 컴파일러는 T를 형식 매개변수 값으로 치환한다.<br/>


## 일반화 클래스
형식은 다음과 같다.<br/>


	class 클래스_이름 < 형식_매개변수 >
	{
	
	    // ...
	}


일반화는 기존에 사용한 것과 다른 값 형식이 들어오면 제네릭 형식의 다른 버전을 생성하여 CIL 위치에 대체한다.<br/>
msdn : https://learn.microsoft.com/ko-kr/dotnet/csharp/programming-guide/generics/generics-in-the-run-time<br/>
참조형식의 경우 이전에 만들어진 것이 있으면 다른 참조형식이 들어와도 이전 형식을 재활용한다고 한다.<br/>


## 형식 매개변수 제약
T는 모든 데이터 형식을 대신할 수 있었다.<br/>
하지만 특정 조건을 갖춘 형식에만 대응하는 형식 매개변수가 필요할 때도 있다.<br/>
이 때 where 절을 추가해 조건에 제약을 줄 수 있다.<br/>


	class MyClass<T> : where T : struct
	{
	
	    // ...
	}


T는 값 형식만 받는다는 의미다. 제약에는 다음과 같이 줄 수 있다.<br/>


|제약|기능|
|:---:|:---|
|where T : struct|T는 값 형식이어야 한다.|
|where T : class|T는 참조 형식이어야 한다.|
|where T : new()|T는 반드시 매개변수가 없는 생성자가 있어야 한다.|
|where T : 부모_클래스_이름|T는 명시한 클래스의 자식 클래스이어야 한다.|
|where T : 인터페이스_이름|T는 명시한 인터페이스를 반드시 구현해야 한다.|
|where T : U|T는 매개변수 U로부터 상속받은 클래스여야 한다.|


## System.Collections.Generic
System.Collections에서 ArrayList, Queue, Stack, Hashtable 자료구조를 확인했었다.<br/>
해당 자료구조들은 object 형식에 기반하고 있어 형식 변환(박싱, 언박싱)이 빈번하게 일어나 성능저하가 심하다.<br/>
일반화 컬렉션인 System.Collections.Genric의 List<T>, Queue<T>, Stack<T>, Dictionary<T>는<br/>
일반화에 기반해서 만들어져 있기 때문에 컬렉션에 사용할 형식이 결정되어 불필요한 형 변환이 없다.<br/>
또한 다른 형식의 데이터를 담을 수 없어 잘못된 데이터의 입력 위험도 피할 수 있다.<br/>


## foreach
일반화 클래스도 IEnumerable 인터페이스를 상속하면 foreach문을 순회할 수 있다.<br/>
하지만 순회할 때마다 형식 변환을 수행하는 오버로드가 발생한다. object Current를 기억하자!<br/>

이러한 문제를 해결하기 위해서는 System.Collections.Generic 네임스페이스에<br/>
IEnumerable<T> 인터페이스를 상속받으면 된다.<br/>
IEnumerable<T>는 IEnumerable 을 상속받기에 System.Collections.IEnumerator GetEnumerator()와<br/>
System.Collections.Generic.IEnumerator<T> GetEnumerator() 의 메소드를 둘 다 구현해야 한다.<br/>

yield 문을 이용하면 컴파일러가 알아서 IEnumerator 상속 받았었다.<br/>
Current, MoveNext, Dispose 함수는 알아서 구현해주나 초기화하는 Reset 함수는 사용할 수 없다.<br/>
System.Collections.Generic.IEnumerator<T>을 상속 받으면 IDisposable 인터페이스를 상속받아 직접 구현해야한다.<br/>
마찬가지로 System.Collections.IEnumerator의 메소드도 구현해야한다.<br/>
msdn : https://learn.microsoft.com/ko-kr/dotnet/csharp/programming-guide/concepts/iterators<br/>

상속 받아야하는 메소드들을 확인하자.<br/>

|상속_받아야할_메소드|해당_인터페이스|
|:---:|:---:|
|System.Collections.IEnumerator GetEnumerator()|IEnumerable<T>|
|System.Collections.Generic.IEnumerator<T> GetEnumerator()|IEnumerable<T>|
|bool MoveNext()|IEnumerator<T>|
|void Reset()|IEnumerator<T>|
|T Current { get; }|IEnumerator<T>|
|object Current { get; }|IEnumerator<T>|
|void Dispose()|IEnumerator<T>|