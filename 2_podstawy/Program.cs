namespace _2_podstawy
{
    internal class Program
    {
        //enumeratory
        enum Colors { zielony, czerwony, czarny, niebieski };
        static void Main(string[] args)
        {
            //Liczba parzysta
            Console.Write("Podaj liczbę:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"Liczba {number} jest parzysta");
            }
            else
            {
                Console.WriteLine($"Liczba {number} jest nieparzysta");
            }

            System.UInt16 a = 10;
            if (a > 50)
            {
                Console.WriteLine("Liczba 51..100");
            }
            else if (a > 100)
            {
                Console.WriteLine("Liczba 101..500");
            }
            else if (a >= 500)
            {
                Console.WriteLine("Liczba >= 500");
            }
            else
            {
                Console.WriteLine("Liczba <= 50");
            }

            //pętla for
            Console.Write("Podaj liczbę:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Console.Write($"{i} ");
            }

            Console.Write("\n\nPodaj koniec pętli:");
            int end = int.Parse(Console.ReadLine());
            for (int i = 1; i < x; i++)
            {
                if (i == end + 1)
                {
                    break;
                }
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n\n");
            //pominięcie wartości
            int x1 = 10, x2 = 20;
            for (int i = 1; i < end; i++)
            {
                if (i == x1 || i == x2) continue;
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n\n");
            for (int i = 1; i < end; i++)
            {
                if (i > 5 && i < 15) continue;
                Console.Write($"{i} ");
            }

            //pętla while
            string t = "";
            do
            {
                Console.Write("Menu\nCzy zakończyć program?");
                t = Console.ReadLine();
            } while (t != "t" && t != "T");


            //switch
            Console.Write("Podaj wartość np. a:");
            string letter = Console.ReadLine();
            switch (letter)
            {
                case "a":
                    Console.WriteLine("Litera a");
                    break;
                case "b":
                    Console.WriteLine("Litera b");
                    break;
                default:
                    Console.WriteLine("Inna litera");
                    break;
            }

            Console.Write("Podaj wartość np. a:");
            string letterNew = Console.ReadLine();
            switch (letterNew)
            {
                case "a":
                case "A":
                    Console.WriteLine("Litera a");
                    break;
                case "b":
                case "B":
                    Console.WriteLine("Litera b");
                    break;
                default:
                    Console.WriteLine("Inna litera");
                    break;
            }

            Colors colorEyes = Colors.niebieski;
            Console.WriteLine(colorEyes);

            int colorInt = (int)Colors.niebieski;
            Console.WriteLine(colorInt);
            //niebieski - 3

            int colorInt2 = (int)Colors.zielony;
            Console.WriteLine(colorInt2);
            //zielony - 0


            Colors color2 = Colors.niebieski | Colors.czerwony;
            Console.WriteLine(color2);
            //niebieski  =>  enum Colors { zielony, czerwony, czarny, niebieski };

            Colors color3 = Colors.zielony | Colors.czerwony;
            Console.WriteLine(color3);
            //czerwony  =>  enum Colors { zielony, czerwony, czarny, niebieski };

            Colors color4 = Colors.czarny | Colors.czerwony;
            Console.WriteLine(color4);
            //niebieski  =>  enum Colors { zielony, czerwony, czarny, niebieski };


            //   |

            bool SecondOperand()
            {
                Console.WriteLine("Second operand");
                return true;
            }

            bool result = true | SecondOperand();
            Console.WriteLine(result); //Second operand true

            bool f = false | SecondOperand();
            Console.WriteLine(f); ////Second operand true


            // &&
            bool result1 = false && SecondOperand();
            Console.WriteLine(result1); //False

            bool result2 = true && SecondOperand();
            Console.WriteLine(result1); //Second operand  false
        }
    }
}