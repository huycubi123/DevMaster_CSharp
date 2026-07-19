using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Guide_01
{
    internal class ListBox : Window
    {
        private string listBoxContent ;

        public ListBox(int top,int left, string listBoxContent) : base(top,left)
        {
            this.listBoxContent = listBoxContent;
        }

        public override void DrawWindow()
        {
            base.DrawWindow(); // Gọi phương thức DrawWindow() của lớp cha (Window) để vẽ cửa sổ cơ bản
            Console.WriteLine("ListBox drawing listbox at {0}",listBoxContent);
        }
    }
}
