namespace _1_podstawy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 45;
            Console.WriteLine(x);
            Console.Clear();

            string t = "";
            t = x.ToString();
            Console.WriteLine(t);

            int y = int.Parse(t);
            Console.WriteLine(y);
            double a = double.Parse(t);
            Console.WriteLine(a);

            Console.WriteLine(a.GetType()); //System.Double
            Console.WriteLine(sizeof(double)); //8 bajtów
            Console.WriteLine(sizeof(float)); //4 bajtów

            Console.WriteLine("Minimalna wartość: " + float.MinValue, ", maksymalna wartość: " + float.MaxValue);

            Console.WriteLine(short.MinValue); //-32768
            Console.WriteLine(short.MaxValue); //32767

            Console.WriteLine(ushort.MinValue); //0
            Console.WriteLine(ushort.MaxValue); //65535
            //int uint

            Console.WriteLine(byte.MinValue); //0
            Console.WriteLine(byte.MaxValue); //255

            Console.WriteLine(sbyte.MinValue); //-128
            Console.WriteLine(sbyte.MaxValue); //127

            Console.WriteLine(Int16.MinValue); //-32768
            Console.WriteLine(Int32.MinValue); //-2147483648
            Console.WriteLine(Int64.MinValue); //-9223372036854775808
            Console.WriteLine(Int128.MinValue); //-170141183460469231731687303715884105728


            // stringi
            Console.Write("Zapis w");
            Console.Write(" jednej linii");
            Console.Write("\nNowa linia" + "\n\tWcięcie w nowej linii\n\n");

            int b = 10;
            Console.WriteLine(b.ToString("C")); //10,00 zł
            Console.WriteLine(b.ToString("C3")); //10,000 zł
            Console.WriteLine(b.ToString("C3").Replace(',', '.')); //10.000 zł
            Console.WriteLine(b.ToString("0000")); //0010

            Console.WriteLine(b.ToString("P")); //1 000,00%
            Console.WriteLine(b.ToString("X")); //A
            Console.WriteLine(b.ToString("N")); //10,00
            Console.Clear();

            double i = 10;
            double j = 20;
            Console.WriteLine((i+j).ToString("00.00")); //30,00
            Console.WriteLine((i+j).ToString("00.000")); //30,000
            Console.WriteLine((i+j).ToString("0000.000")); //0030,000

            Console.WriteLine((i+j).ToString("###.##")); //30

            Console.Write("Podaj imię:");
            string? _firstName = Console.ReadLine();
            Console.WriteLine("Twoje imię: " + _firstName);

            Console.Write("Podaj nazwisko:");
            string? _lastName = Console.ReadLine();

            //interpolacja
            Console.WriteLine("Imię: {1}, nazwisko: {0}", _lastName, _firstName);

            //kolory
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            //pozycja kursora
            Console.CursorTop = 2;
            Console.CursorLeft = 30;
            Console.WriteLine("C#");

            

        }
    }
}