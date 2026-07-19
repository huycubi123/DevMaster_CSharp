using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_4_Guide
{
    internal class Program
    {
        static void Main(string[] args)
        {
             IPerson staff = new Staff();
            object data = "Bach Khoa Aptech";
            // xu ly cac hanh dong 
            staff.Insert(data);
            staff.Delete(data);
            staff.Update(data);
            staff.Display(data);
            // tao sinh vien 
            IPerson student = new Student() {Id="S10",Name="Huy",Age=20 };
            // hien thi 
            student.Display(student);

        }

    }
}
