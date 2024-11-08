# Ch02 입문
## CLR
CLR(Common Language Runtime)은 C#으로 만든 프로그램이 실행되는 환경이다


런타임이 C# 뿐 아니라 CLS(Common Language Specification)규격을 따르는 모든 언어로 작성된 프로그램을 지원하기 때문이다<br/>
CLR은 단순히 각 언어로 작성된 프로그램의 실행뿐 아니라 서로 다른 언어로 작성된 언어 사이의 호환성을 제공하기도 한다<br/>
  - 간단하게 C# 프로그램을 실행해주는 또 다른 프로그램으로 봐도 된다

C# 컴파일러는 C# 소스코드를 컴파일 해서 IL(Intermediate Language)이라는 중간 언어로 작성된 실행 파일을 만들어 낸다.<br/>
사용자가 파일을 실행시키면 하드웨어가 이해할 수 있는 네이티브 코드로 컴파일한 후 실행 시킨다<br/>
이를 JIT(Just In Time) 컴파일이라 한다.<br/>
JIT 컴파일은 실행에 필요한 코드를 실행할 때마다 실시간으로 컴파일해서 실행한다.<br/>


CLR은 C# 뿐만 아니라 다른 언어도 지원하도록 설계되어있다.<br/>
서로 다른 언어들이 만나기 위한 지점이 바로 IL 이라는 중간 언어이고,<br/>
이 언어로 쓰인 코드를 CLR이 다시 자신이 설치된 플랫폼에 최적화시켜 컴파일한 후 실행하는 것이다<br/>


이 방식의 장점은 플랫폼에 최적화된 코드를 만들어낸다는 것이며,<br/>
단점은 컴파일 비용의 부담이다<br/>


## namespace
네임스페이스는 성격이나 하는 일이 비슷한 클래스, 구조체, 인터페이스, 대리자 열거 형식 등을 하나의 이름 아래 묶는 일을 한다


## class
클래스는 C# 프로그램을 구성하는 기본 단위로서 데이터와 데이터를 처리하는 기능(Method)으로 이루어진다


## Main
Main 메소드는 프로그램의 진입점(프로그램이 시작되는 첫 번째 코드)으로서 프로그램을 시작하면 실행되고,<br/>
이 메소드가 종료되면 프로그램도 역시 종료된다


모든 프로그램은 Main이라는 이름을 가진 메소드 하나 가지고 있어야 한다


## static
static은 한정자로서 메소드나 변수 등을 수식한다<br/>
C# 프로그램의 각 요소는 코드가 실행되는 시점에 비로소 메모리에 할당되는 반면,<br/>
static 키워드로 수식되는 코드는 프로그램이 처음 구동될 때부터 진작에 메모리에 할당된다는 특징이 있다