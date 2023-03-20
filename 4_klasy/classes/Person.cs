using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Person
    {
        public string firstName = "Janusz";
        public string lastName = "";

        public float height = 0f;
        public float weight = 0f;

        private string pesel = "99012112345";

        public string getPesel()
        {
            return pesel;
        }

        public void setPesel(string _pesel)
        {
            pesel = _pesel;
        }

        public string Pesel
        {
            set { pesel = value; }
            get { return pesel; }
        }

        public void show()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public string info()
        {
            return "Imię i nazwisko: " + firstName + " " + lastName + ", waga: " + weight + "kg, wzrost: " + height + "cm";
        }
    }
}
