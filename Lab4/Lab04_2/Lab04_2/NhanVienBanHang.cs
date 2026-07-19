using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_2
{
    internal class NhanVienBanHang : NhanVien
    {
        int soLuongBanDuoc;
        public NhanVienBanHang (int soLuongBanDuoc, string Ten, string DiaChi) : base(Ten, DiaChi)
        {
            this.soLuongBanDuoc = soLuongBanDuoc;
        }
        public override double TinhLuong()
        {
            return soLuongBanDuoc * 100000;
        }
        public override void HienThi()
        {
            Console.WriteLine("Lương nhân viên là: "+ TinhLuong());
        }
    }
}
