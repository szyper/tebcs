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


        }
    }
}