using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name;
            int number;
            double money = 0;

            Console.Write("Nhap ten thue bao:");
            name = Console.ReadLine();

            Console.Write("Nhap so dien su dung:");
            number = Convert.ToInt32(Console.ReadLine());

            if (number <= 30)
            {
                money = 30;
            }
            else if (number > 30 && number <= 50)
            {
                money = 30 + (number - 30) * 1.2;
            }
            else if (number > 50)
            {
                money = 30 + 20 * 1.2 + (number - 50) * 1.5;
            }

            Console.WriteLine("\n Thong tin tien dien");
            Console.WriteLine("Ho va ten:{0}", name);
            Console.WriteLine("So dien su dung:{0}", number);
            Console.WriteLine("So tien:{0:C}", money);
        }
    }
}
