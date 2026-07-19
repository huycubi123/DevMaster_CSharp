using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_2
{
    internal class CongNhan : NhanVien
    {
        public int soLuongSanPham;
        public CongNhan(int soLuongSanPham, string Ten, string DiaChi) :base(Ten,DiaChi) {
            this.soLuongSanPham = soLuongSanPham;
        }
        public override double TinhLuong()
        {
            return soLuongSanPham * 20000;
        }
        public override void HienThi()
        {
            Console.WriteLine("Lương công nhân: " + TinhLuong());
        }
    }
}
