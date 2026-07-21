using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_04
{
    internal abstract class Employee : Person
    {
        public string Department { get; set; }
        public double Salary { get; set; }
        public DateTime DateHired { get; set; }

        public Employee(string name, string phoneNumber, string emailAddress, string department, double salary, DateTime dateHired)
            : base(name, phoneNumber, emailAddress)
        {
            Department = department;
            Salary = salary;
            DateHired = dateHired;
        }
        public abstract double CalculateBonus();
        public abstract int CalculateVacation();

        public override string ToString()
        {
            return $"{base.ToString()}, Department: {Department}, Salary: ${Salary}";
        }
    }
}
