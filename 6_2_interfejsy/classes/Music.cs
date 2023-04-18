using _6_2_interfejsy.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_interfejsy.classes
{
    internal class Music : IPlayable, ISearchable
    {
        public void Stop()
        {
            Console.WriteLine("Klasa Music - metoda STOP");
        }

        public void Pause()
        {
            Console.WriteLine("Klasa Music - metoda PAUSE");
        }

        public void Play()
        {
            Console.WriteLine("Klasa Music - metoda PLAY");
        }

        void ISearchable.Fwd()
        {
            Console.WriteLine("Klasa Music - metoda FWD");

        }

        void ISearchable.Rev()
        {
            Console.WriteLine("Klasa Music - metoda REV");
        }

        void ISearchable.FastFwd()
        {
            Console.WriteLine("Klasa Music - metoda FastFwd");

        }

        void ISearchable.FastRev()
        {
            Console.WriteLine("Klasa Music - metoda FastRev");

        }

        public ISearchable GetSearch()
        {
            return this;
        }
    }
}
