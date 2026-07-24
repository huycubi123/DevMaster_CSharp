using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Guide_4
{
    internal class Chapter
    {
        private string name;
        private string content; 
        public Chapter()
        {
            name = " ";
            content = " ";
        }
        public Chapter(string name ,string content) 
        {
            this.name = name;
            this.content = content;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()    // Khi in đối tượng ra màn hình bằng CW sẽ tự động gọi hàm này 
        {
            return name + "\n" + content;
        }

    }
}
