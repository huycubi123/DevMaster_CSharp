using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] names = {"Thang", "Long", "Hieu", "Hanh", "Khah" };
            Console.WriteLine("Danh sach sinh vbien");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
