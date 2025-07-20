using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.UserInputDemo
{
    public class Person
    {
        public Person(DateOnly dob)
        {
            _age = DateTime.Now.Year - dob.Year;
            DateOfBirth = dob;
        }

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateOnly DateOfBirth { get; init; }
        public decimal Salary { get; set; }
        public char Gender { get; set; }
        public bool IsWorking { get; set; }

        private readonly int _age;

        public int GetNumberOfWorkingYearsRemaining()
        {
            return Constants.RetirementAge - _age;
        }

        public DateOnly GetEstimatedRetirementDate()
        {
            return DateOnly.FromDateTime(DateTime.Now.AddYears(GetNumberOfWorkingYearsRemaining()));
        }

        public int GetAge()
        {
            return _age;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
