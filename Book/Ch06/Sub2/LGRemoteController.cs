using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    // 인터페이스 구현
    internal class LGRemoteController : IRemoteController
    {
        public void ChDown()
        {
            Console.WriteLine("LG ChDown...");
        }

        public void ChUp()
        {
            Console.WriteLine("LG ChUp...");
        }

        public void PowerOff()
        {
            Console.WriteLine("LG PowerOff...");
        }

        public void PowerOn()
        {
            Console.WriteLine("LG PowerOn...");
        }

        public void SoundDown()
        {
            Console.WriteLine("LG SoundDown...");
        }

        public void SoundUp()
        {
            Console.WriteLine("LG SoundUp...");
        }
    }
}
