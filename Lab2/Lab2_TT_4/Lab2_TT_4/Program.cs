using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TT_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 100; i <= 999; i++)
            {
                if (i % 2 == 0)
                {
                    string tach = i.ToString();
                    // lấy ra kí tự đầu tiên 
                    int tach1 = Convert.ToInt32(tach[0].ToString());
                    int tach2 = Convert.ToInt32(tach[1].ToString());
                    int tach3= Convert.ToInt32(tach[2].ToString());
                    if ((tach1 + tach2 + tach3) == 3)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
