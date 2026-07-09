using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TT_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập cạnh a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập cạnh b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhập cạnh c: ");
            int c = int.Parse(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0 && (a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("Ba số vừa nhập tao thanh một tam giác.");

                if (a == b && b == c)
                {
                    Console.WriteLine("Kết quả: Đây là tam giác deu.");
                }
                else if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a))
                {
                    if (a == b || b == c || a == c)
                    {
                        Console.WriteLine("Kết quả: Đây là tam giác vuong can.");
                    }
                    else
                    {
                        Console.WriteLine("Kết quả: Đây là tam giác vuongh.");
                    }
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Kết quả: Đây là tam giác can.");
                }
                else
                {
                    Console.WriteLine("Kết quả: Đây là tam giác bthg.");
                }
            }
            else
            {
                Console.WriteLine("Ba số vừa nhập ko la một tam giác.");
            }
            Console.ReadKey();
        }
    }
}
