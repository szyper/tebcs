using _6_2_interfejsy.classes;
using _6_2_interfejsy.interfaces;

namespace _6_2_interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            IPlayable[] tabMedia = new IPlayable[4];

            tabMedia[0] = new Film();
            tabMedia[1] = new Film();
            tabMedia[2] = new Music();
            tabMedia[3] = new Comedy();

            foreach (IPlayable media in tabMedia)
            {
                media.Stop();
            }
            Console.WriteLine();
            */

            /*
            for (int i = 0; i < tabMedia.Length; i++)
            {
                tabMedia[i].Stop();
            }
            Console.WriteLine();
            */

            IPlayable[] tab = new IPlayable[4];
            tab[0] = new Film();
            tab[0].Stop();

            //tab[0].FastRev();

            ISearchable s = (ISearchable)tab[0];
            s.FastRev();

            tab[0].GetSearch().FastRev();

            if (tab[0] is IRecordable)
            {
                ((IRecordable)tab[0]).Rec();
            }
            Console.WriteLine();

            tab[1] = new Music();
            tab[1].Stop();
            if (tab[1] is IRecordable)
            {
                ((IRecordable)tab[1]).Rec();
            }

        }
    }
}