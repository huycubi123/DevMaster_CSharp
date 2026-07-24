using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            int nam;
            Console.WriteLine("Nhập năm: ");
            nam = int.Parse(Console.ReadLine());
            string[] CAN = new string[] { "Canh", "Tân", "Nham", "Quý" ,"Giáp", "Ất", "Bính ", "Đinh", "Mậu", "Kỷ" };
            string[] CHI = new string[] { "Thân", "Dậu", "Tuất", "Hợi","Tí", "Sửu", "Dần","Mão","Thìn","Tị","Ngọ","Mùi", };
            string ThienCan = CAN[nam%10];
            string ThienChi= CHI[nam%12];
            Console.WriteLine("Năm theo Can Chi là: " + ThienCan +" " + ThienChi);
            int chai = nam % 12;
            Console.WriteLine(chai);
            Console.ReadKey();

        }
    }
}

