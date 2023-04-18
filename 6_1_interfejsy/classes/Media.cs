using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_interfejsy.classes
{
    internal class Media
    {
        public virtual void Stop()
        {
            Console.WriteLine("Klasa Media - Stop");
        }

        public virtual void Play()
        {
            Console.WriteLine("Klasa Media - Play");
        }

        public virtual void Pause()
        {
            Console.WriteLine("Klasa Media - Pause");
        }
    }
}
