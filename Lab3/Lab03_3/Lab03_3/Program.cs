using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tạo đối tượng 
            StudentModel action = new StudentModel();
            // Lấy tất cả sinh viên 
            List<Student> list = action.GetStudents();
            // hiển thị 
            foreach (var item in list)
            {
                item.HienThi();
            }
            // lấy sinh viên theo id 
            Student st = action.GetStudents(3);  
            // hiển thị sinh viên 
            Console.WriteLine(st);

            // Lấy sinh viên theo tuổi 19-21
            List<Student> list2 = action.GetStudents(19, 21);
            foreach (var item in list2)
            {
                item.HienThi();
            }
        }
    }
}
