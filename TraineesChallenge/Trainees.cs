using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineesChallenge
{

    internal class Trainees : Employee
    {
        public double WorkingHours;
        public double SchoolHours;
        public Trainees(string name, string firstName, int salary, double workingHours, double schoolHours) : base(name, firstName, salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("Learning a lot");
        }

        public new void Work()
        {
            Console.WriteLine($"The trainee has worked {WorkingHours} hours");
        }
    }
}
