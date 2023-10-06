using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineesChallenge
{
    internal class Employee
    {
        public string Name;
        public string FirstName;
        public int Salary;

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("Working...");
        }

        public void Pause()
        {
            Console.WriteLine("Having a break...");
        }


    }
}
