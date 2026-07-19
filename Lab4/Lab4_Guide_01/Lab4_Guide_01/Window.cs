using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Guide_01
{
    internal class Window
    {
        protected int top; 
        protected int left;
        // Khởi tạo 
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        // phương thức vitural vẽ cửa sổ 
        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: Drawing a window at {0} to {1}", top, left);
        }
    }
}
