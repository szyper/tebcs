using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_dziedziczenie.classes
{
    internal class Person
    {
        public string firstName = "";
        public string lastName = "";

        public Person() { }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string Info()
        {
            return "Imię i nazwisko: " + firstName + " " + lastName;
        }
    }
}
