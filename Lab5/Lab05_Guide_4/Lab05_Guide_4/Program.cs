using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Guide_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Book b = new Book("Programing with Csharp ", 4);
            // Nhập thông tin theo các chương 
            b[0] = new Chapter("Chapter 1", "Introduction to CSharp");
            b[1] = new Chapter("Chapter 2", "DataType and variable in CSharp");
            b[2] = new Chapter("Chapter 3", " Input and Output in Console Application");
            b[3] = new Chapter("Chapter 4", "Statêmnts Conditions and Loops");
            // In thông tin sách 
            Console.WriteLine("List of Book ");
            Console.WriteLine(b.Name);
            // danh sách các chương 
            for (int i=0; i<4;i++ )
            {
                Console.WriteLine(b[i]);
            }
            // Thông tin chương 3 
            Console.WriteLine("Detail of Chapter 3");
            Console.WriteLine(b["Chapter 3"]);
            Console.ReadKey();

        }
    }
}
