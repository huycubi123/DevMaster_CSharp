using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_03
{
    internal interface IStorage
    {
        string Data { get; set; }
        void Read(string fileName);
        void Write(string fileName);

    }
}
