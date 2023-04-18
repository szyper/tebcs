using _6_2_interfejsy.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_interfejsy.classes
{
    internal class Comedy : Film
    {
        public override void Stop()
        {
            Console.WriteLine("Klasa Comedy - metoda STOP");
        }

        public override void Pause()
        {
            Console.WriteLine("Klasa Comedy - metoda PAUSE");
        }

        public override void Play()
        {
            Console.WriteLine("Klasa Comedy - metoda PLAY");
        }
    }
}
