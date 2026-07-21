using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5_Guide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            // sử dụng start 
            Console.WriteLine("Sdung start"); 
            myCar.Start();
            Console.WriteLine("Sdung tủn left ");
            myCar.TurnLeft();
            Console.WriteLine("sdung Accerating");
            myCar.Accelerate();
            Console.ReadKey();
        }
    }
}
