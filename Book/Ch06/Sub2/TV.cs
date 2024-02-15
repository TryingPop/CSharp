using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    // C#에서는 다중 상속은 안된다
    // 그래서 하나는 상속 다른 하나는 구현한다
    internal class TV : Internet, Computer
    {
        public void PowerOn()
        {
            Console.WriteLine("TV PowerOn...");
        }

        public void AccessInternet()
        {
            base.Access();
        }

        public void Booting()
        {
            Console.WriteLine("TV Booting");
        }
    }
}
