using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_interfejsy.classes
{
    internal class Music : Media
    {
        public override void Stop()
        {
            Console.WriteLine("Klasa Music - Stop");
        }

        public override void Play()
        {
            Console.WriteLine("Klasa Music - Play");
        }

        public override void Pause()
        {
            Console.WriteLine("Klasa Music - Pause");
        }
    }
}
