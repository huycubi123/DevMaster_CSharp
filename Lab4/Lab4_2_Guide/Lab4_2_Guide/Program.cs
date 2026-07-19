using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2_Guide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student of College: ");
            StudentCollege studentCollege = new StudentCollege("Huy", 2004, 8.5, 9.0, 8.5);
            studentCollege.HienThi();
            Console.WriteLine("Average of score:"+ studentCollege.TinhDiem());
            // Hiển thông tin sinh viên 
            Console.WriteLine("Student of University: ");
            StudentUniversity studentUniversity = new StudentUniversity("Huy", 2004, 8.5, 9.0, 8.5, 9.0);
            studentUniversity.HienThi();
            Console.WriteLine("Average of score:"+ studentUniversity.TinhDiem());
        }
    }
}
