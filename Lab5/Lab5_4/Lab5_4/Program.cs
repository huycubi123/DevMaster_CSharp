using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Department department = new Department("Phòng Nhân Sự", 4);
            department[0] = new Employee(1, "Nam", 20);
            department[1] = new Employee(2, "Trung", 19);
            department[2] = new Employee(1, "Thái", 21);
            department[3] = new Employee(3, "Dương", 20);
            
            Console.WriteLine("Thông tin các nhân sự tại phòng "+ department.Name);
            for (int i = 0; i < department.GetLength(); i++) {
                Console.WriteLine(department[i]);
            }
            Console.ReadLine();
        }
    }
}
