using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    // 인터페이스 : 오직 추상메서드만 갖는 구조체
    // 인터페이스 만들 때 대문자 I로 시작
    internal interface IRemoteController
    {
        public abstract void PowerOn();
        public abstract void PowerOff();

        // abstract 생략
        // 인터페이스에서는 abstract 생략가능
        public void ChUp();
        public void ChDown();

        public void SoundUp();
        public void SoundDown();
    }
}
