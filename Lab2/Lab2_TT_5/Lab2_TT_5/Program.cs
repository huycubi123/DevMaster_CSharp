using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TT_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tam giác vuông trái 
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("o ");

                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------");
            // Tam giác vuông trái trên
            for (int i = 5; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("o ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------");
            // Tam giác vuông phải dưới 
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    if (j < 5 - i)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("o ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------");
            // tam giác vuông phải trên 
            for (int i = 5; i >= 0; i--)
            {
                for (int j = 0; j <= 5; j++)
                {
                    if (j < 5 - i)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("o ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------");
            // tam giác đỉnh ở giữa 
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    if (j < 5 - i)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("o ");
                    }
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("o ");
                }
                Console.WriteLine();
            }
        }
    }
}
