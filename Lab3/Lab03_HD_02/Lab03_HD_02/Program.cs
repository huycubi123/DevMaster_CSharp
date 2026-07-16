using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_HD_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact ct1 = new Contact();
            ct1.Id = 1;
            ct1.FirstName = "Nguyen";
            ct1.LastName = "Van A";
            ct1.Email = "email@email1";
            ct1.Phone = "0123456789";
            ct1.Address = "Address 1";
            ct1.HienThi();

            Console.WriteLine("------------------------");   
            
            Contact ct2 = new Contact(2,"Tran", "Thi B", "email2@email","0999999921", "Ha Noi" );
            ct2.HienThi();

            Console.ReadKey();
        }
    }
}
