using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Guide_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student st= new Student(3,2); // 3 sinh viên mỗi sinh viên 2 điểm 
            // Sử dụng chỉ mục để truy cập vào thành phần mảng của lớp 
            st[0] = "Huy";
            st[0,0] = 9; st[0,1] = 10;
            st[1] = "Nam"; 
            st[1,0] = 6; st[1,1] = 7;
            st[2] = "Sơn";
            st[2,0]= 8; st[2,1]= 4;

            // Hiển thị thông tin 
            Console.WriteLine("Hiển thị thông tin học sinh: ");
            for(int i=0; i< 3;i++)
            {
                Console.WriteLine($"Ho tên sinh viên thứ {i+1}: {st[i]}");
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Điểm môn thứ {j+1} là {st[i,j]}");
                }
            }
            Console.ReadKey();
        }
    }
}
