using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Guide_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[,] arr = new int[4,3] { { 1, 3, 5, }, { 2,5,7}, { 9,9,11},{4,6,10 } };
            Console.WriteLine("In ra ma trận ");
            for (int i=0; i < arr.GetLength(0);i++)
            {
                for(int j=0;j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+ " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("In ra các phần tử có cùng chỉ số hàng bằng cột");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(arr[i,j] + " ");
                    }
                }
            }
            
            Console.WriteLine("In ra các phần tử lớn nhất từng hàng");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int max = arr[i,0];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i,j])
                    {
                       max= arr[i,j];
                    }
                }
                Console.WriteLine($"Giá trị phần tử lớn nhất hàng {i} là {max}"); 
            }
            Console.ReadKey();
        }
    }
}
