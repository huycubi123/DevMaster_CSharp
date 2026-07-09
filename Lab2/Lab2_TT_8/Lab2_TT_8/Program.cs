using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TT_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding =Encoding.UTF8;

            // 1. Nhập dữ liệu nhanh
            Console.Write("Nhập tiền gốc: ");
            double goc = double.Parse(Console.ReadLine());

            Console.Write("Nhập lãi suất năm (%): ");
            double laiNam = double.Parse(Console.ReadLine());

            Console.Write("Nhập số tháng gửi: ");
            int thang = int.Parse(Console.ReadLine());

            // 2. Tính lãi suất tháng và lưu lại số tiền gốc ban đầu để trừ lúc sau
            double laiThang = (laiNam / 12) / 100;
            double gocBanDau = goc;

            // 3. Vòng lặp ngắn gọn để gộp lãi vào gốc từng tháng
            for (int i = 0; i < thang; i++)
            {
                goc += goc * laiThang; // Tiền gốc tự cộng thêm tiền lãi của chính nó
            }

            // 4. Xuất kết quả
            Console.WriteLine($"\nSố dư cuối kỳ: {goc:N0}");
            Console.WriteLine($"Tiền lãi cuối kỳ: {(goc - gocBanDau):N0}");

            Console.ReadLine();
        }
    }
}
