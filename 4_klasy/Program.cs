namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.firstName); //Janusz
            person.firstName = "Krzysztof";
            Console.WriteLine(person.firstName); //Krzysztof
            person.lastName = "Nowak";
            Console.WriteLine();

            person.show();
            Console.WriteLine(person.info());
            //Console.WriteLine(person.pesel);
            Console.WriteLine("Pesel: " + person.getPesel());
            //person.pesel = "12345678901";

            person.Pesel = "09876543211";
            Console.WriteLine(person.Pesel);

            Employee pracownik = new Employee("Janusz", "Nowak");
        }
    }
}