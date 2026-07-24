using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Guide_4
{
    internal class Book
    {
        private string name;
        private Chapter[] chapters;
        public Book() { }
        public Book (string name , int n)
        {
            this.name = name;
            chapters = new Chapter[n];  // Cấp phát mảng n chương 
        }
        public string Name
        { get { return name; }
            set {
                if (name == value) {
                    throw new ArgumentException(); // Ném ngoại lệ nếu tên mới trùng tên cũ
                }
                name = value;
            }
        }
        // index thứ nhất có một tham số kiểu int là số chương để truy cập và gán theo index số nguyên b[0]ư, ...
        public Chapter this[int index]   // Cú phpas biến đối tượng Book thành 1 mảng cho phép đọc/ghi chương sách thông qua số thứ tự (ví dụ: myBook[0] = new Chapter(...)).
        {
            get
            {
                if (index < 0 || index > chapters.Length - 1) // Nếu index vượt phạm vi mảng, trả về null
                {
                    return null;
                }
                return chapters[index];
            }
            set
            {
                if (index<0||index > chapters.Length-1)    
                {
                    throw new ArgumentException();    // Nếu vượt phạm vi thì báo lỗi
                }
                chapters[index] = value;
            }
        }
        // index thứ 2 có một tham số kiểu string overload indexer
        public Chapter this[string name]    // Truy cập theo tên chương 
        {
            get
            {
                foreach (Chapter ch in chapters)
                {
                    if (ch.Name==name)
                    {
                        return ch;
                    }
                }
                return null;
            }
        }
    }
}
