using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_04
{
    internal class Student : Person
    {
        public string Program { get; set; } // Ngành học: Business, Computer Science...
        public Student(string name, string phoneNumber, string emailAddress, string program)
            : base(name, phoneNumber, emailAddress)
        {
            Program = program;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Program: {Program}";
        }

    }
}
