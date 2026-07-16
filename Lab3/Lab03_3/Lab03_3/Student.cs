using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_3
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age{ get; set; }
        public Student() { }
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public void HienThi()
        {
            Console.WriteLine($"Id: {Id} \t  Name: {Name} \t Description: {Age}");
        }

    }
}
