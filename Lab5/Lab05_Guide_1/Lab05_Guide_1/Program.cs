using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Guide_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int [] { 3, 2, 4, 1, 4, 56, 7, 9, 12, 10 };
            Console.WriteLine("In ra các phần từ: ");
            for (int i=0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
            }
            // Phần tử nhỏ nhất trong mảng
            int min =arr[0];
            for (int i=1;i<arr.Length;i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine("Phân tử nhỏ nhất trong mảng arr là : "+ min);
            // Kiểm tra mảng đối xứng 
            bool flag =true;
            for (int i= 0; i < arr.Length;i++) { 
                if (arr[arr.Length-i-1] != arr[i])
                {
                   flag= false; break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Mảng đối xứng ");
            }
            else { Console.WriteLine("Mảng không đối xứng "); 
            }
            
        }
    }
}
