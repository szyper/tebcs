using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_interfejsy.interfaces
{
    internal interface IPlayable
    {
        void Stop();
        void Pause();
        void Play();

        ISearchable GetSearch();
    }
}
