using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Guide_01
{
    internal class Button : Window
    {
        public Button(int top, int left) : base(top, left)
        {
           
        }
        public override void DrawWindow()
        {
            Console.WriteLine("Button drawing buton at {0}, {1} \n", top, left);
        }
    }
}
