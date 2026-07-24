using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_4
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Employee(int id , string name , int age) {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return "Id: " + Id + ", Name: " + Name + ", Age:" + Age;
        }

    }
}
