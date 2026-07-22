using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Guide_3
{
    internal class Student
    {
        string[] names;
        double [,] mark;
        public Student(int n, int m)
        {
            names = new string[n];
            mark = new double[n, m];
        }
        // Chỉ mục đơn 
        public string this[int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }
        // chỉ mục kép 
        public double this[int i, int j]
        {
            get { return mark[i, j]; }
            set { mark[i, j] = value; }
        }

    }
}
