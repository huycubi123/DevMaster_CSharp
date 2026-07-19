using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_2
{
    internal abstract class NhanVien
    {
        public string Ten;
        public string DiaChi;

        public NhanVien(string Ten, string DiaChi) { 
            this.Ten = Ten;
            this.DiaChi = DiaChi;
        }

        public abstract double TinhLuong();
        public abstract void HienThi();
        
    }
}
