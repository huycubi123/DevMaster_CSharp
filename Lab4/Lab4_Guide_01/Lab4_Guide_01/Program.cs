using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Guide_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo các đối tượng 
            Window win = new Window(10, 20);
            ListBox listBox = new ListBox(30, 40, "ListBox Content");
            Button button = new Button(50, 60);

            win.DrawWindow();
            listBox.DrawWindow();
            button.DrawWindow();

            // Khởi tạo mảng
            Window[] windows = new Window[3];
            windows[0] = new Window(1, 2);
            windows[1] = new ListBox(3, 4, "ListBox of Array");
            windows[2] = new Button(5, 6);

            for (int i=0; i< windows.Length;i++)
            {
                windows[i].DrawWindow();
            }
            Console.ReadKey();
        }
    }
}
