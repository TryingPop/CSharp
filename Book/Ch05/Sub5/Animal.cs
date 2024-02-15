using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub5
{
    internal class Animal
    {
        // 오버라이드 할 것이므로 virtual 선언
        public virtual void Move() 
        {
            Console.WriteLine("Animal Move ...");
        }
    }
}