using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TT_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int giay= Convert.ToInt32(Console.ReadLine());
            int phut;
            int gio;
            if ( giay>60)
            {
                gio=(giay%(3600*24))/3600;
                phut=(giay/(3600))/60;
                giay=giay%60;
            }
            else
            {
                gio = 0;
                phut = 0;
            }
            Console.WriteLine("{0}:{1}:{2}", gio.ToString("00"), phut.ToString("00"), giay.ToString("00"));
            Console.ReadKey();
        }
    }
}
