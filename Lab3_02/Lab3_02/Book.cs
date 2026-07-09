using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_02
{
    internal class Book
    {
        public string author { get; set; }
        public int page { get; set; }
        public string isbn { get; set; }
        public string title { get; set; }
        public int currentPage { get; set; }

        public Book()
        {
            this.author = "";
            this.page = 0;
            this.isbn = "";
            this.title = "";
            this.currentPage = 1;
        }

        public Book(string author, int page, string isbn, string title)
        {
            this.author = author;
            this.page = page;
            this.isbn = isbn;
            this.title = title;
            this.currentPage = 1;
        }
        // Tiến lên trang tiếp
        public void flipPageForward()
        {
            if (this.currentPage < this.page)
            {
                this.currentPage++;
            }
            else
            {
                Console.WriteLine("You are already at the last page.");
            }
        }
        // Quay lại trang trước
        public void flipPageBackward(int page)
        {
            if (this.currentPage > 1)
            {
                this.currentPage -= page;
                if (this.currentPage < 1)
                {
                    this.currentPage = 1;
                }
            }
            else
            {
                Console.WriteLine("Ở trang đầu rồi ");
            }
        }
    }
}
