using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab04_04
{
    internal class Person
    {
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string emailAddress { get; set; }
        public Person(string name , string phone , string emailAddress)
        {
            this.name = name;
            this.phoneNumber = phone;
            this.emailAddress = emailAddress;
        }
        public override string ToString()
        {
            return $"[{GetType().Name}] Name: {name}, Email: {emailAddress}";
        }

    }
}
