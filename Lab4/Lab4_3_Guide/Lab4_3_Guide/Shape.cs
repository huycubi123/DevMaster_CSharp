using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3_Guide
{
    internal abstract class Shape
    {
        protected float radius, length, witdh;
        public abstract float Area(); // Diện tích 
        public abstract float Circumference(); // Chu vi 
    }
}
