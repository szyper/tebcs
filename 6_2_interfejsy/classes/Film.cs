using _6_2_interfejsy.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_interfejsy.classes
{
    internal class Film : IPlayable, ISearchable, IRecordable
    {
        public virtual void Stop()
        {
            Console.WriteLine("Klasa Film - metoda STOP");
        }

        public virtual void Pause()
        {
            Console.WriteLine("Klasa Film - metoda PAUSE");
        }

        public virtual void Play()
        {
            Console.WriteLine("Klasa Film - metoda PLAY");
        }
        void ISearchable.Fwd()
        {
            Console.WriteLine("Klasa Film - metoda FWD");
        }

        void ISearchable.Rev()
        {
            Console.WriteLine("Klasa Film - metoda REV");
        }

        void ISearchable.FastFwd()
        {
            Console.WriteLine("Klasa Film - metoda FastFwd");
        }

        void ISearchable.FastRev()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Klasa Film - metoda FastRev");
        }

        public ISearchable GetSearch()
        {
            return this;
        }

        public void Rec()
        {
            Console.WriteLine("Klasa Film - metoda REC");
        }
    }
}
