using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_4
{
    internal class Department
    {
        public string Name { get; set; }
        Employee[] employees;
        public Department(string name , int n) { 
            this.Name= name;
            employees = new Employee[n];
        }
        public int GetLength()
        {
            return employees.Length;
        }
        public Employee this[int index]
        {
            get
            {
                if (index < 0 || index > employees.Length - 1)
                {
                    return null;
                }
                return employees[index];
            }
            set
            {
                if (index < 0 || index > employees.Length - 1)
                    throw new ArgumentException();
                employees[index] = value; 
            }
        }
        public Employee this[string name]
        {
            get
            {
                foreach(Employee em in employees)
                {
                    if (em.Name == name)
                    {
                        return em;
                    }
                }
                return null;
            }
        }
    }
}
