using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;
            Console.Write("a=");
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            while (a == 0);
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            c = Convert.ToInt32(Console.ReadLine());

            delta = b * b - 4 * a * c;

            if (delta < 0)
                Console.Write("Phuong trinh vo nghiem");
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem kep");
                Console.WriteLine("x1=x2={0}", -b / (2 * a));
            }
            else
            {
                Console.WriteLine("Phuong trinh co 2 nghiem");
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1={0}", x1);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x2={0}", x2);
            }
        }
    }
}
