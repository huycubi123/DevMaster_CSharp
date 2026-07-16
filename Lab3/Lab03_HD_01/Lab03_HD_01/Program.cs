using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_HD_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo đối tượng 
            Car myCar = new Car();
            myCar.make = "Toyota";
            myCar.model = "Camry";
            myCar.color = "Red";
            myCar.year = 2020;
            Console.WriteLine("Hiển thị thông tin ");
            Console.WriteLine("Make: " + myCar.make);
            Console.WriteLine("Model: " + myCar.model);
            Console.WriteLine("Color: " + myCar.color);
            Console.WriteLine("Year: " + myCar.year);
            // Gọi phương thức 
            myCar.Srart();
            myCar.Stop();
            Console.ReadLine();
        }
    }
}
