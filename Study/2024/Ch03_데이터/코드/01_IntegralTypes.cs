using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 21
이름 : 배성훈
내용 : IntegralTypes
    교재 p 39 ~ 49

    리터럴에 관한 이야기와 스텍, 힙 메모리 영역에 관한 내용이 있다
    프로젝트를 옮기니 CS0579 어트리뷰트 중복에러가 일어났다
    중복 문제이니 하나만 지워주면 된다

    찾아보니 중복 어셈블리 생성을 막는 방법도 있는데
    프로젝트 솔루션에서 해당 프로젝트를 더블클릭 한 뒤 해당 프로퍼티를 추가해주면 된다고 한다
	<PropertyGroup>
		<GenerateAssemblyInfo>false</GenerateAssemblyInfo>
	</PropertyGroup>

    이미 생성된 거같아 일단은 다 지웠다

    그리고 윈폼 문제도 있었는데
    <FrameworkReference Include ="Microsoft.WindowsDesktop.App"/>
    해당 프레임워크를 참조할 수 있게 하니 이상없이 된다
*/
namespace Study._2024.Ch03
{
    internal class _01_IntegralTypes
    {

        static void Main1(string[] args)
        {

            sbyte a = -10;
            byte b = 40;

            Console.WriteLine($"a = {a}, b = {b}");

            short c = -30000;
            ushort d = 60000;

            Console.WriteLine($"c = {c}, d = {d}");

            int e = -1000_0000;
            uint f = 3_0000_0000;

            Console.WriteLine($"e = {e}, f = {f}");

            long g = -5000_00000_0000;
            ulong h = 200_0000_0000_0000_0000;

            Console.WriteLine($"g = {g}, h = {h}");
        }
    }
}
