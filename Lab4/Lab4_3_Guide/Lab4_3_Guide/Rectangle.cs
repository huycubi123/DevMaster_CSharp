using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3_Guide
{
    internal class Rectangle : Shape
    {
        public void InputData()
        {
            Console.WriteLine("Nhap chieu dai: ");
            length=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            witdh = int.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            return length * witdh;
        }
        public override float Circumference()
        {
            return 2 * length * witdh;
        }
    }
}
