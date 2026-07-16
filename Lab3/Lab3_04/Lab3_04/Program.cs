using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=20, b = 30;
            double area;
            Ultility ultility = new Ultility();
            Console.WriteLine("Trước khi hoán vị: a= {0},b={1}",a,b);
            ultility.SwapFake(a, b);
            Console.WriteLine("Sau khi hoán vị (không sử dụng ref): a= {0},b={1}", a, b);
            Console.WriteLine("Trước khi hoán vị: a= {0},b={1}", a, b);
            ultility.SwapReal(ref a, ref b);
            Console.WriteLine("Sau khi hoán vị (sử dụng ref): a= {0},b={1}", a, b);

            ultility.SwapOut(5, out area);  // Với out thì không cần giá trị ban đầu của area, nó sẽ được gán trong phương thức SwapOut
            Console.WriteLine("Diện tích hình tròn có bán kính 5 là: {0}", area);
        }
    }
}
