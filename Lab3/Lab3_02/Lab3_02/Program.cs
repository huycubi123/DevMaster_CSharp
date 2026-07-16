using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Book book1 = new Book("Author 1", 100, "ISBN001", "Title 1");
            Console.WriteLine("Trang hiện tại:" + book1.currentPage);
            book1.flipPageForward();
            Console.WriteLine("Trang sau lật: "+ book1.currentPage);
            book1.flipPageBackward(50);
            Console.WriteLine("Trang lật về : " + book1.currentPage);
            Console.ReadKey();
        }
    }
}
