using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Employee
    {
        public int id {get; set; }
        public string name {get; set; }
        public int yearOfBirth {get; set; }
        public double salaryLevel { get; set; }
        public double basicSalary {get; set; }
    
        public double GetIntcome() {
            return salaryLevel * basicSalary;  
        }
        public void Display()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Year of Birth: {yearOfBirth}, Salary Level: {salaryLevel}, Basic Salary: {basicSalary}, Income: {GetIntcome()}");
        }
        public Employee()
        {
            
        }
        public Employee(int id, string name, int yearOfBirth, double salaryLevel, double basicSalary)
        {
            this.id = id;
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.salaryLevel = salaryLevel;
            this.basicSalary = basicSalary;
        }
    }
}
