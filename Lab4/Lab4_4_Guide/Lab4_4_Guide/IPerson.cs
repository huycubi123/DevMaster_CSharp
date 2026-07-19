using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_4_Guide
{
    internal interface IPerson
    {
        void Insert(object obj);
        void Delete(object obj);
        void Update(object obj);
        void Display(object obj); 
    }
}
