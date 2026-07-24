using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_1
{
    internal class Program
    {
        static bool SNT(int n)
        {
            if (n <2) return false;
            for (int i = 2; i < Math.Sqrt(n); i++) {
                if (n % i == 0)
                   return false;                                 
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = new int[] { 3, 1, 4, 5, 8, 6, 9, 12, 10, 11 };
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Phần tử nhỏ nhất trong mảng là: "+ min);
            // Đảo ngược mảng
            Array.Reverse(arr);
            Console.WriteLine("Mảng sau đảo ngược là: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
            }
            Console.WriteLine();
            // Sắp xếp mảng tăng dần: 
            Array.Sort(arr);
            Console.WriteLine("Mảng sau sắp xếp là: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            // Sắp xếp giảm dần
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++) {
                    if(arr[j] > arr[i])
                    {
                        int tam = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tam;
                    }
                }
            }
            Console.WriteLine("Hàm sắp xếp giảm dần: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            // Tìm phần tử là số nguyên tố 
            Console.Write("Danh sách số nguyên tố: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (SNT(arr[i]))
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();

            int[] arr2 = new int[] { 1, 3, 2, -3, -6, 4, 5, -6, 7, 12, 22 ,33};
            int dem2 = 0;
            int dem = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] > 0 ){ dem++; }
                    if (dem > dem2) dem2 = dem; 
                else { dem = 0; }
            }
            Console.WriteLine("Số các số dương liên tiếp nhiều nhất là: " + dem2);
            // Tính trung bình cộng các số dương
            int dem3 = 0;
            int tong = 0;
            for (int i = 0; i < arr2.Length; i++) {
                if (arr2[i] > 0) {
                    dem3++;
                    tong += arr2[i];
                }
            }
            if (dem3 == 0) { Console.WriteLine("Không có số nguyên dương nào"); }
            else { Console.WriteLine("Trung bình cộng số nguyên dương trong dãy là: {0}", (float)tong/dem3); }

            // Kiểm tra có số âm dương đan xen không?
            bool flag = true;
            for (int i = 0; i < arr2.Length-1; i++) {
                if (arr2[i] > 0 && arr2[i + 1] >= 0)
                {
                   flag = false;
                }
            }
            if (!flag) { Console.WriteLine("Dãy không đan xen "); }
            else { Console.WriteLine("Dãy đan xen"); }
            Console.ReadKey();
        } 
    }
}
