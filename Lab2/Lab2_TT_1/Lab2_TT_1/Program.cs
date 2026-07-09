using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TT_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            int id;
            string name;
            string address;
            DateTime dateOfBirth;
            float salary;
            float bonus;
            float totalSalary;
            Console.WriteLine("Nhập lần lượt các thông tin: ");
            id=int.Parse(Console.ReadLine());
            name = Console.ReadLine();
            address = Console.ReadLine();
            dateOfBirth = DateTime.Parse(Console.ReadLine());  //08/07/2026 17:47:00
            salary = float.Parse(Console.ReadLine());
            bonus = float.Parse(Console.ReadLine());
            Console.WriteLine("Tổng tiển: {0}" , salary+bonus);
            Console.ReadKey();
        }
    }
}
