using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5_Guide
{
    internal interface IDrivable
    {
        void Start();
        void Stop();

        bool Started
        {
            get;
        }

    }
}
