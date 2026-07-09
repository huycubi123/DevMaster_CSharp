using System;

namespace Lab2_TT_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()); // năm
            int y = int.Parse(Console.ReadLine()); // tháng 
            int soNgay = 0;

            switch (y)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    soNgay = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    soNgay = 30;
                    break;

                case 2:
                    if (x % 400 == 0 || (x % 4 == 0 && x % 100 != 0))
                    {
                        soNgay = 29;
                    }
                    else
                    {
                        soNgay = 28;
                    }
                    break;
                default:
                    Console.WriteLine("Tháng không hợp lệ!");
                    return;
            }

            Console.WriteLine("Tháng {0} có {1} ngày", y, soNgay);
        }
    }
}
