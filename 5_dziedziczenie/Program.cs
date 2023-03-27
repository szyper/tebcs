using _5_dziedziczenie.classes;
using static _5_dziedziczenie.classes.Driver;

namespace _5_dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Janusz", "Nowak");
            Console.WriteLine(person.Info());

            Employee employee = new Employee("Anna", "Nowak", 25.50f, 168);
            Console.WriteLine(employee.Info());

            Driver driver = new Driver("Janusz", "Nowak", 33.5f, 168, new List<drivingLicenseCategory> { drivingLicenseCategory.a, drivingLicenseCategory.c});

            driver.drivingLicenseCategories.Add(Driver.drivingLicenseCategory.b);

            Console.WriteLine(driver.Info());
        }
    }
}