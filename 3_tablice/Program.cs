using System.Runtime.CompilerServices;

namespace _3_tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tablice
            int[] tabInt = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < tabInt.Length; i++)
            {
                Console.Write(tabInt[i] + " ");
            }
            Console.WriteLine();

            foreach (int x in tabInt)
            {   
                Console.Write($"{x} ");
            }
            Console.WriteLine();

            //modyfikacja
            for (int i = 0; i < tabInt.Length; i++)
            {
                tabInt[i] *= 2;
                Console.Write(tabInt[i] + " ");
            }
            Console.WriteLine();

            //min max
            int[] tab = { 1, 10, 15, -4, 55, 34, 100, -5, 22};
            Console.WriteLine("Minimum: " + tab.Min());
            Console.WriteLine("Maksimum: " + tab.Max());

            foreach (var item in tab)
            {
                Console.Write($"{item} ");
            }
            
            Console.WriteLine("Odwrotność:");
            Array.Reverse(tab);
            foreach (var item in tab)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("Odwrotność:");

            //sortowanie
            Array.Sort(tab);
            foreach (var item in tab)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Array.Reverse(tab);
            foreach (var item in tab)
            {
                Console.Write($"{item} ");
            }
            //100 55 34 22 15 10 1 -4 -5
            Console.WriteLine();

            Array.Reverse(tab, 2, 5);
            foreach (var item in tab)
            {
                Console.Write($"{item} ");
            }
            //100 55 1 10 15 22 34 -4 -5
            Console.WriteLine();

            Array.Reverse(tab, 4, 3);
            foreach (var item in tab)
            {
                Console.Write($"{item} ");
            }
            //100 55 1 10 34 22 15 -4 -5
            Console.WriteLine();

            Array.Sort(tab);
            foreach (var item in tab)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            //-5 -4 1 10 15 22 34 55 100

            int z = Array.BinarySearch(tab, -5);
            Console.WriteLine(z); //0

            z = Array.BinarySearch(tab, 10);
            Console.WriteLine(z); //3

            z = Array.BinarySearch(tab, 99);
            Console.WriteLine(z); //-9

            z = Array.BinarySearch(tab, 100000);
            Console.WriteLine(z); //-10

            z = Array.BinarySearch(tab, 66);
            Console.WriteLine(z); //-9
            Console.WriteLine();

            //tablice wielowymiarowe
            Console.WriteLine("Tablice wielowymiarowe");
            int[,] tabs = new int[2, 4];
            int xTabs = tabs.GetLength(0);
            //Console.WriteLine(xTabs); //2

            int yTabs = tabs.GetLength(1);
            //Console.WriteLine(yTabs); //4

            /*
            tabs[0, 0] = 0;
            tabs[0, 0] = 1;
            tabs[0, 1] = 2;
            tabs[0, 2] = 3;
            */

            int count = 0;
            for (int i = 0; i < xTabs; i++)
            {
                
                for (int j = 0; j < yTabs; j++)
                {
                    tabs[i, j] = count;
                    count++;
                }
            }

            for (int i = 0; i < xTabs; i++)
            {
                for (int j = 0; j < yTabs; j++)
                {
                    Console.Write(tabs[i,j] + " ");
                }
                Console.WriteLine();
            }



        }
    }
}