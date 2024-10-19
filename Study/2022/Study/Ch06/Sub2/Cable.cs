using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class Cable : Socket
    {
        private Bulb bulb;

        public Cable(Bulb bulb)
        {
            this.bulb = bulb;
        }

        public void SwitchOff()
        {
            this.bulb.LigthOff();
        }

        public void SwitchOn()
        {
            this.bulb.LightOn();
        }
    }
}
