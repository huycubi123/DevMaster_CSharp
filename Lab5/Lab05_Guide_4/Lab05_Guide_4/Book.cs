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
            chapters = new Chapter[n];
        }
        public string Name
        { get { return name; }
            set {
                if (name == value) {
                    throw new ArgumentException(); 
                }
                name = value;
            }
        }
        // index thứ nhất có một tham số kiểu int là số chương 
        public Chapter this[int index]
        {
            get
            {
                if (index < 0 || index > chapters.Length - 1)
                {
                    return null;
                }
                return chapters[index];
            }
            set
            {
                if (index<0||index > chapters.Length-1)
                {
                    throw new ArgumentException();
                }
                chapters[index] = value;
            }
        }
        // index thứ 2 có một tham số kiểu string overload indexer
        public Chapter this[string name]
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
