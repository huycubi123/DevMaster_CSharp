using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TT_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 10;

            for (int i = 1; i <= rows; i++)
            {
                for (int j= 1;j <= rows - i; j++)
                {
                    Console.Write("  "); 
                }

                int num = i;

                for (int j = 1; j <= i; j++)
                {
                    Console.Write((num % 10) + " ");
                    num++;
                }
                num -= 2;

                for (int j = 1; j < i; j++)
                {
                    Console.Write(((num % 10 + 10) % 10) + " ");
                    num--;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
