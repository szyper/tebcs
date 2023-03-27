using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_dziedziczenie.classes
{
    internal class Employee : Person
    {
        private float ratePerHour = 0f;
        private ushort numberOfWorkHours = 0;

        public Employee() { }

        public Employee(string firstName, string lastName, float ratePerHour, ushort numberOfWorkHours) : base(firstName, lastName)
        {
            this.ratePerHour = ratePerHour;
            this.numberOfWorkHours = numberOfWorkHours;
        }

        private float Salary()
        {
            return ratePerHour * numberOfWorkHours;
        }

        public new string Info()
        {
            return base.Info() + " " + lastName + ", pensja: " + Salary().ToString("c2");
        }
    }
}

