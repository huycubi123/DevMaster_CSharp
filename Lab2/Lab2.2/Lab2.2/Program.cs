using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Nhap vao ky tu: ");
            ch=(char)Console.Read();
            switch (ch)
            {
                case 'a':
                case 'o':
                case 'e':
                case 'u':
                case 'i': Console.WriteLine("{0} la so nguyen am",ch);
                    break;
                default: Console.WriteLine("{0} la so phu am", ch);
                    break;
            }


        }
    }
}
