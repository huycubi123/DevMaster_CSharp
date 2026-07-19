using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_1
{
    internal class Account
    {
        public double moneyLive ; // tồn tại theo vòng đời của đối tượng 
        public Account() { }
        public Account(double initialize) {
            moneyLive = initialize;
        }
        public virtual void Deposit(double money)
        {
            moneyLive = moneyLive + money;
            Console.WriteLine("Đã thêm số tiền gửi");

        }
        public virtual void Withdraw(double money)
        {
            moneyLive = moneyLive - money;
            Console.WriteLine("Số tiền cần rút là: {0}", money);

        }
        public double getBalance()
        {
            return moneyLive;
        }

    }
}
