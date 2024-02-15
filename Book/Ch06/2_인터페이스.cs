using Ch06.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.20
 * 내용 : 인터페이스 실습하기 교재 p425
 * 
 * 인터페이스(Interface)
 *  - 클래스 설계를 위해 공통의 표준 가이드 역할을 하는 구조체 
 *  - 인터페이스를 활용해서 객체간 결합도를 완화
 */

namespace Ch06
{
    internal class _2_인터페이스
    {
        static void Main2(string[] args)
        {
            // 인터페이스로 공통 클래스 구조설계에 활용
            IRemoteController lg = new LGRemoteController();
            IRemoteController ss = new SamsungRemoteController();

            lg.PowerOn();
            lg.ChUp();
            lg.SoundUp();

            ss.PowerOn();
            ss.ChDown();
            ss.SoundDown();

            // 인터페이스로 다중 상속에 활용
            // 다형성 사용 불가능
            // 2명한테 상속받아서 부모를 설정할 수 없다
            // 다중 상속은 지양해야하는 문법
            TV smartTV = new TV();

            smartTV.PowerOn();
            smartTV.Booting();
            smartTV.AccessInternet();


            // 중요
            // 인터페이스로 객체간 결합도 완화에 활용
            Bulb bulb = new Bulb();
            Socket socket = new Cable(bulb);

            socket.SwitchOn();
            socket.SwitchOff();
        }
    }
}
