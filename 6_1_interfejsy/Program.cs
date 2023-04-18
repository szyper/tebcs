using _6_1_interfejsy.classes;

namespace _6_1_interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Media[] media = new Media[4];

            media[0] = new Film();
            media[1] = new Music();
            media[2] = new Film();
            media[3] = new Music();

            foreach (Media item in media) 
            {
                item.Stop();
            }
            Console.WriteLine();

            for (int i = 0; i < media.Length; i++)
            {
                media[i].Play();
            }
            Console.WriteLine();


        }
    }
}