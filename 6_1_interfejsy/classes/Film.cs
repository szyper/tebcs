using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_interfejsy.classes
{
    internal class Film : Media
    {
        public override void Stop()
        {
            Console.WriteLine("Klasa Film - Stop");
        }

        public override void Play()
        {
            Console.WriteLine("Klasa Media - Play");
        }

        public override void Pause()
        {
            Console.WriteLine("Klasa Media - Pause");
        }
    }
}
