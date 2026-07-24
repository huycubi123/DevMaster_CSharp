using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[,] arr = new int[4, 4] { { 2,3,1,4},{ 3, 3, 5, 2 },{ 7,4,9,5},{ 10,12,8,7} };

            // cách tạo mảng ngẫu nhiên 
            //int[,] arr3 = new int[4, 4];
            //Random rand = new Random();
            //for (int i = 0; i < arr3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr3.GetLength(1); j++)
            //    {
            //        arr3[i, j] = rand.Next(-9, 9);
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("In mảng theo hàng, cột");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t"); 
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // Tính tổng ptu số hàng bằng số cột
            int tong1 = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        tong1 += arr[i, j];  
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tổng các phần tử có số hàng = cột là: " + tong1);
            // In ra các phần tử nhỏ nhất theo cột
            for (int i = 0;i < arr.GetLength(1); i++)
            {
                int min = arr[0, i];

                for (int j = 0;j < arr.GetLength(0); j++)
                {
                    if (min > arr[j,i])
                    {
                        min = arr[j,i];
                    }
                }
                Console.WriteLine($"Phân từ nhỏ nhất cột {i} là : {min}");
            }
            Console.WriteLine();
            // In ra phần từ lớn nhất theo hàng 
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int max = arr[i, 0];

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                }
                Console.WriteLine($"Phân từ lớn nhất hàng {i} là : {max}");
            }
            Console.WriteLine();
            Console.WriteLine("Các phần từ chia hết cho 7 là:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j]%7==0)
                        Console.Write(arr[i, j] + " ");
                }
            }
            Console.WriteLine();

            //Tính tổng các phần tử nằm trên đường viền của mảng
            int tong2 = 0;
            for (int i = 0;i < arr.GetLength(0); i++)
            {
                for(int j = 0;j < arr.GetLength(1); j++)
                {
                    if (j==0 | j==3 | i ==0 | i==3)
                    {
                        tong2 += arr[i, j];
                    }
                }
            }
            Console.WriteLine("Tổng các phần từ nằm trên đường viền của mảng là " + tong2);

            //Chuyển thành mảng một chiều 
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);
            int[] arr2 = new int[row*col];
            int k = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            { 
                for(int j=0; j<arr.GetLength(1);j++)
                {
                    arr2[k++] = arr[i,j];
                    
                }
            }
            
            // Mảng sau khi chuyển thành 1 chiều là : 
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i]+ " "  );
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
