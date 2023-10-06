using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineesChallenge
{
    internal class Boss : Employee
    {

        public string CompanyCar;
        public Boss(string name, string firstName, int salary, string companyCar) : base(name, firstName, salary)
        {
            this.CompanyCar = companyCar;
            this.Salary = salary;
            this.FirstName = firstName;
            this.Name = name;
            CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("Leading!...");
        }
    }
}
