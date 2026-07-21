using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 1. Tạo đối tượng Student
            Student student = new Student("Nguyen Van A", "01234783", "a@gmail.com", "Computer Science");
            Console.WriteLine(student);

            Console.WriteLine("--------------------------------------------------");

            // 2. Tạo đối tượng Faculty
            Faculty faculty = new Faculty("Dr. Tran Van B", "0912345678", "b@gmail.com", "IT", 20000000, new DateTime(2018, 5, 20), "8:00 - 11:00", "Professor");
            Console.WriteLine(faculty);
            Console.WriteLine($"-> Bonus: ${faculty.CalculateBonus()}");
            Console.WriteLine($"-> Vacation: {faculty.CalculateVacation()} weeks");

            Console.WriteLine("--------------------------------------------------");

            // 3. Tạo đối tượng Staff
            Staff staff = new Staff("Le Thi C", "0923456789", "c@university.edu", "HR", 15000000, new DateTime(2021, 10, 10), "Manager");
            Console.WriteLine(staff);
            Console.WriteLine($"-> Bonus: ${staff.CalculateBonus()}");
            Console.WriteLine($"-> Vacation: {staff.CalculateVacation()} weeks");

            Console.ReadLine();
        }
    }
}
