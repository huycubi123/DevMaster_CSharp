using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_HD_01
{
    internal class Car
    {
        public String make;
        public String model;
        public String color;
        public int year;
        public void Srart()
        {
            Console.WriteLine(model+ " khoi dong ");
        }
        public void Stop()
        {
            Console.WriteLine(model + " dung lai ");
        }
    }
}
