using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_04
{
    internal class Ultility
    {
        // Không sử dụng ref
        public void SwapFake(int a , int b ) {

            int tg = a;
            a = b;
            b = tg;
        }

        // Sử dụng ref
        public void SwapReal(ref int a, ref int b)
        {
            int tg = a;
            a = b;
            b = tg;
        }
        // Sử dụng out
        public void SwapOut(double radius, out double area )
        {
            area = 2 * Math.PI * radius ;
        }
        // Khi không sử dụng ref hoặc out thì giá trị của biến sẽ không thay đổi bên ngoài phương thức. Khi sử dụng ref hoặc out, giá trị của biến sẽ được thay đổi bên ngoài phương thức.
        // Khác nhau giữa ref và out là ref yêu cầu biến phải được khởi tạo trước khi truyền vào phương thức, trong khi out không yêu cầu biến phải được khởi tạo trước khi truyền vào phương thức.

    }
}
