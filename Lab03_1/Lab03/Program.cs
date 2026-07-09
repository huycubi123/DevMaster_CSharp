using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, "John Doe", 1990, 2.5, 5000);
            emp1.Display();
            Console.ReadKey();
        }
    }
}
