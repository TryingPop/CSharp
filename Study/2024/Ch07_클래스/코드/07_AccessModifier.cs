using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 접근 한정자로 공개 수준 결정하기
    교재 p 245 ~ 248

    객체 지향 프로그래밍에서도 클래스 사용자에게 필요한 최소의 기능만 노출하고
    내부를 감출 것을 요구한다. 이것을 은닉성이라 한다.

    그리고 필드는 상수가 아니라면 무조건 감추는 것이 좋다.
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _07_AccessModifier
    {

        class WaterHeater
        {

            protected int temperature;

            public void SetTemperature(int temperature)
            {

                if (temperature < -5 || temperature > 42)
                {

                    throw new Exception("Out of temperature range");
                }

                this.temperature = temperature;
            }

            internal void TurnOnWater()
            {

                Console.WriteLine($"Turn on water : {temperature}");
            }
        }

        static void Main7(string[] args)
        {

            try
            {

                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50);
                heater.TurnOnWater();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
