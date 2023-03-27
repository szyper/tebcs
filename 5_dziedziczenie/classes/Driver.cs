using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_dziedziczenie.classes
{
    internal class Driver : Employee
    {
        public enum drivingLicenseCategory { a, b, b1, c };

        //public string[]? drivingLicenseCategories = { drivingLicenseCategory.b1.ToString()};        
        //public drivingLicenseCategory? drivingLicenseCategories;

        public List<drivingLicenseCategory> drivingLicenseCategories = new List<drivingLicenseCategory>();

        //public Driver() { }
        public Driver(string firstName, string lastName, float ratePerHour, ushort numberOfWorkHours, List<drivingLicenseCategory> drivingLicenseCategories) : base (firstName, lastName, ratePerHour, numberOfWorkHours)
        {
            this.drivingLicenseCategories = drivingLicenseCategories;
        }
        
            //public Driver(string firstName, string lastName, float ratePerHour, ushort numberOfWorkHours) : base (firstName, lastName, ratePerHour, numberOfWorkHours)
        //{
            //this.drivingLicenseCategories = drivingLicenseCategories;
        //}

        public string getDrivingLicenseCategories()
        {
            string licenses = "";
            foreach(drivingLicenseCategory item in drivingLicenseCategories)
            {
                licenses += item.ToString() + " ";
            }
            return licenses;
        } 

        public new string Info()
        {
            return base.Info() + ", kategoria prawa jazdy: " + getDrivingLicenseCategories();
        }
    }
}
