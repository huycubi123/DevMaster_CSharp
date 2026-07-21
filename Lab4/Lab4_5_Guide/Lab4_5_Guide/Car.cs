using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5_Guide
{
    internal class Car : IMovable
    {
        private bool _started = false;
        public void Start()
        {
            Console.WriteLine("Car started ");
            _started= true;
        }
        public void Stop()
        {
            Console.WriteLine("Car stop");
            _started = false;
        }
        public bool Started
        {
            get {
                return _started;
            }
        }
        public void TurnLeft()
        {
            Console.WriteLine("car turning left  ");
        }
        public void TurnRight()
        {
            Console.WriteLine("car turning right");
        }
        public void Accelerate()
        {
            Console.WriteLine("Car accelerating");
        }
        public void Brake()
        {
            Console.WriteLine("Car braking");
        }

    }
}
