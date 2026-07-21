using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Tạo đối tượng 
            Document document = new Document();
            document.content = "Thực hành lab 4 bài 3";
            string fileName = "test_document.txt";  // File sinh trong phần debug 
            Console.WriteLine("Test ghi file");
            document.Write(fileName);
            Console.WriteLine("Test đọc file ");
            document.Read(fileName);
            // Thay đổi nội dung trước khi đọc
            document.content = "Nội dung thay đổi";
            Console.WriteLine($"Nội dung trc khi đọc lại {document.content}");
            // Test giao diện mã hóa 
            document.Encrypt();
            document.Decrypt();
            Console.ReadKey();
        }
    }
}
