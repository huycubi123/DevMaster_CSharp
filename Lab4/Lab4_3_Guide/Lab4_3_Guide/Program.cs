using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3_Guide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            // Nhap 
            rectangle.InputData();
            // in thong tin 
            Console.WriteLine("Dien tich hinh chu nhat : "+ rectangle.Area());
            Console.WriteLine("Chu vi hinh chu nhat: "+ rectangle.Circumference());
            // Hinh tron 
            Circle circle = new Circle();
            circle.InputData();
            Console.WriteLine("Dien tich hinh tròn: " + circle.Area());
            Console.WriteLine("Chi vi hinh tron: "+ circle.Circumference());
        }
    }
}
