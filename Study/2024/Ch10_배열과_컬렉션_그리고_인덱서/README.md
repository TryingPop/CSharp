# Ch10 배열과 컬렉션 그리고 인덱서
## 배열
같은 성격을 띤 다수의 데이터를 한번에 다뤄야하는 경우가 있다.<br/>
다루는 수가 적은 경우 변수를 일일히 할당해서 해결할 수 있다.<br/>
하지만 개수가 100_000 이상으로 많다면 변수할당은 에러사항이 있다.<br/>
이러한 문제를 해결해주는게 배열이다.<br/>

배열은 다음과 같은 형식으로 선언할 수 있다.<br/>


	데이터_형식[] 배열_변수_이름 = new 데이터_형식[ 용량 ];


C# 8.0부터는 System.Index 형식과 ^ 연산자가 생겼다.<br/>
^연산자는 컬렉션의 마지막부터 역순으로 인덱스를 지정하는 기능을 갖고 있다.<br/>
^연산의 결과는 System.Index 형식의 인스턴트로 나타난다.<br/>
System.Index는 읽기전용 필드 value를 가진 구조체 이고, 인덱스를 읽는데 사용된다.<br/>


배열을 초기화하는 방법은 다음과 같은 세 가지가 있다.<br/>


	int[] arr1 = new int[3] { 0, 1, 2 };
	int[] arr2 = new int[] { 0, 1, 2 };
	int[] arr3 = { 0, 1, 2 };


## System.Array
C#에서는 모든 것이 객체이다. 배열도 당연히 객체이며 .NET의 CTS에서 배열은 System.Array 클래스에 대응된다.<br/>
데이터 형식을 알려주는 GetType() 메소드와 BaseType 프로퍼티로 확인가능하다.<br/>
Array 클래스에는 다음과 같은 메소드들이 있다.<br/>


|분류|메소드_이름|기능|
|:---:|:---:|:---|
|정적 메소드|Sort()|배열을 정렬한다.|
|정적 메소드|BinarySearch<T>()|T의 비교 관계에 맞춰 이진 탐색을 한다.|
|정적 메소드|IndexOf()|배열에서 해당 원소가 있으면 해당 원소의 인덱스를 반환한다.|
|정적 메소드|TrueForAll<T>()|배열의 모든 요소가 지정한 조건에 부합하는지 여부를 반환한다.|
|정적 메소드|FindIndex<T>()|배열에서 지정한 조건에 부합하는 첫 번째 원소를 찾는다.|
|정적 메소드|Resize<T>()|배열의 크기를 재조정한다.|
|정적 메소드|Clear()|배열의 모든 요소를 초기화한다. 숫자면 0, 논리면 false, 참조형이면 null|
|정적 메소드|ForEach<T>()|배열의 모든 요소에 동일한 작업을 수행한다.|
|정적 메소드|Copy<T>()|배열의 일부 원소를 복사한다.|
|인스턴스 메소드|GetLength()|배열에서 지정한 차원의 길이를 반환한다.|
|프로퍼티|Length|배열의 길이를 반환한다.|
|프로퍼티|Rank|배열의 차원을 반환한다.|


## 배열 분할
C# 8.0에서부터 System.Index 형식과 함께 도입된 System.Range가 있다.<br/>
System.Range는 Index 두 개를 갖고 있고 이로 인덱스 범위를 표현하는 데이터다.<br/>
.. 연산자를 이용해 범위가 표현된다. 숫자를 이용하면 알아서 Range 구조체를 만든다.<br/>
만약 시작 범위를 입력하지 않으면 0, 끝 범위를 입력하지 않으면 ^1이 자동으로 채워진다.<br/>


	int[] arr = new int[5] { 1, 2, 3, 4, 5 };
	int[] slice1 = arr[1..2];	// 2, 3
	int[] slice2 = arr[..3];	// 1, 2, 3, 4
	int[] slice3 = arr[3..];	// 4, 5

위처럼 사용할 수 있다.<br/>


## 2차원 배열과 다차원 배열
배열의 차원을 2개로 나눈게 2차원 배열이다. 차원은 인덱스를 나누는 기준이라 보면 된다.<br/>
선언방법은 1차원 배열처럼 할 수 있다.<br/>


	int[,] arr2D_1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
	int[,] arr2D_2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
	int[,] arr2D_3 = { { 1, 2, 3 }, { 4, 5, 6 } };


위에서 만들어지는 이차원 배열은 다음과 같은 표로 데이터가 있다고 생각하면 된다.<br/>


|1|2|3|
|:---:|:---:|:---:|
|4|5|6|


원소의 좌표는 아래와 같다.<br/>


|0, 0|0, 1|0, 2|
|:---:|:---:|:---:|
|1, 0|1, 1|1, 2|


코드로는 다음처럼 접근할 수 있다.


	int[,] arr2D = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
	int one = arr2D[0, 0];	// 1
	int two = arr2D[0, 1];	// 2
	int five = arr2D[1, 1];	// 5


2차원 배열은 구분 기준이 하나에서 두 개로 늘어난 것 뿐이다.<br/>
다차원 배열은 2차원 배열 확장하듯이 구분 기준을 여러 개로 늘린 것이다.<br/>
3차원 이상의 배열은 그림으로 그리기 힘들고 머릿속으로 내용을 유지하는것도 힘들다.<br/>
이는 버그를 일으킬 위험을 내포하고 있고 유지보수가 힘들다.<br/>


## 가변 배열
가변 배열은 배열을 요소로 갖는 배열이라 보면 된다.<br/>
다차원 배열은 해당 차원에서 봤을 때 배열의 크기가 고정되어있지만 가변 배열은 원소간 길이가 서로 달라도 된다.<br/>
선언 방법은 다음과 같다.<br/>


	데이터_형식[][] 배열_이름 = new 데이터_형식[ 가변배열의_용량 ][];



## System.Collections
컬렉션(Collection)은 같은 성격을 띈 데이터의 모음을 담는 자료구조다.<br/>
.NET에서 제공하는 컬렉션은 다음과 같다.<br/>
  - ArrayList
  - Queue
  - Stack
  - Hashtable

System.Array역시 ICloneable, IList, ICollection, IEnumerable 인터페이스를 상속받음으로<br/>
컬렉션 중 하나임을 알 수 있다.<br/>

System.Collections에 있는 자료구조는 모두 object 형식으로 박싱해 데이터를 보관하고,<br/>
값을 가져올 때는 언박싱해서 가져오기에 많은 데이터를 담으면 성능저하가 심하다.<br/>
Collections.Generic 클래스의 자료구조를 위한 발판으로만 보면 된다.<br/>

Queue나 Stack은 


## ArrayList
ArrayList의 장점은 용량을 지정할 필요가 없다. 필요에 따라 자동으로 용량이 늘어나거나 줄어든다.<br/>
Add(), RemoveAt(), Insert() 메소드가 있다.<br/>
Add 메소드는 원소를 뒤에 추가하는 것이다. RemoveAt은 특정 위치의 원소를 제거하는 것이다.<br/>
Insert는 특정 위치에 원소를 추가하는 것이다.<br/>


## Queue
큐는 먼저 들어온게 먼저 나가는 FIFO(First In First Out)인 자료구조다.<br/>
원소를 추가할 때는 Enqueue(), 원소를 뺄 때는 Dequeue() 메소드를 이용하면 된다.<br/>
내부는 두 포인터로 구현되어져 있다. 그리고 알아서 원소의 개수에 맞게 용량을 늘린다.<br/>


## Stack
스택은 나중에 들어온게 먼저 나가는 LIFO(Last In First Out)인 자료구조다.<br/>
원소를 추가할 때는 Push(), 원소를 뺄 때는 Pop()을 하면 된다.<br/>
내부는 끝을 나타내는 하나의 포인터로 작동한다. Queue와 마찬가지로 원소의 개수에 맞게 용량을 늘린다.<br/>


## Hashtable
Hashtable은 키(Key)와 값(Value)쌍으로 이루어진 데이터를 다룰 때 사용한다.<br/>
Hashtable은 배열에서 인덱스를 이용해 배열 요소에 접근하는 것에 준하는 탐색속도를 자랑한다.<br/>
키를 사용해 데이터가 저장된 컬렉션 내의 주소를 계산하는데 이 작업을 해싱이라 한다.<br/>
SourceLink의 설명에보니 충돌시 다음 값에 결정은 다음 2개의 값으로 연산한다.<br/>


	h1(key) = GetHash(key);  // default implementation calls key.GetHashCode();
	h2(key) = 1 + (((h1(key) >> 5) + 1) % (hashsize - 1));


구문이 있음을 확인할 수 있다. 여기에 n은 충돌 횟수이고 h1(key)는 모든 수를 나타낼 수 있다고 한다.<br/>
Knuth's Art of Computer Programming, Vol. 3, p. 528-9 해당 부분을 참고했다고 한다.<br/>


## 인덱서
인덱서(Indexer)는 인덱스(Index)를 이용해서 객체 내의 데이터에 접근하게 해주는 프로퍼티라고 생각하면 이해하기 쉽다.<br/>
인덱서는 다음과 같이 선언할 수 있다.<br/>


	class 클래스_이름
	{
	
	    한정자 인덱서_형식 this[ 형식 index ]
	    {
	
	        get
	        {
	
	            // index를 이용하여 내부 데이터 반환
	        }
	
	        set
	        {
	
	            // index를 이용하여 내부 데이터 저장
	        }
	    }
	}


## foreach 가능한 객체 만들기
foreach문은 for문처럼 요소의 위치를 위한 인덱스 선언을 할 필요가 없다.<br/>
foreach문은 코드도 쓰기 좋고 읽기도 쉽다.<br/>

foreach문은 IEnumerable을 상속하는 형식만 지원한다.<br/>
System.Collections.IEnumerator를 반환하는 GetEnumerator()를 정의하고 yield문을 이용해 정의하면,<br/>
컴파일러가 알아서 IEnumerable 인터페이스를 상속한다.<br/>

각 호출마다 yield return이나 yield break문을 만날 때까지 나머지 작업을 실행한다.<br/>


IEnumerator에는 다음 메소드와 프로퍼티가 있다.<br/>


|타입|이름|기능|
|:---:|:---:|:---|
|메소드|bool MoveNext()|다음 요소로 이동한다. 끝을 지난 경우에 false, 이동이 성공한 경우 true|
|메소드|void Reset()|컬렉션의 첫 번재 위치의 앞으로 이동한다.|
|프로퍼티|object Current|컬렉션의 현재 요소를 반환|


GetEnumerator 메소드를 구현할 때는 자기자신을 반환하면 된다.<br/>