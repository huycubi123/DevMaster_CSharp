using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id, name;
            double mark1, mark2, mark3, average;
            DateTime birthday;

            Console.Write("Nhap ma so:");
            id = Console.ReadLine();

            Console.Write("Nhap ten:");
            name = Console.ReadLine();

            Console.Write("Nhap ngay sinh:");
            birthday = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Nhap diem mon 1:");
            mark1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem mon 2:");
            mark2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem mon 3:");
            mark3 = Convert.ToDouble(Console.ReadLine());

            //tính điểm trung bình
            average = (mark1 + mark2 + mark3) / 3;

            //In thông tin ra màn hình
            Console.WriteLine("\n Thong tin sinh vien");
            Console.WriteLine("Ma so:{0}", id);
            Console.WriteLine("Ho va ten:{0}", name);
            Console.WriteLine("Ngay sinh:{0:dd/MM/yyyy}", birthday);
            Console.WriteLine("Diem 1:{0:N}, Diem 2:{1:N}, Diem 3:{2:N}", mark1, mark2, mark3);
            Console.WriteLine("Diem trung binh:{0:N}", average);
        }
    }
}
