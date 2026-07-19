using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Tạo với đối tượng Account 
            Account account = new Account(1000);
            account.Deposit(500);
            account.Withdraw(200);
            Console.WriteLine("Số dư hiện tại là: {0}", account.getBalance());
            Console.WriteLine("-----------------------------------------------");

            // Gửi tiết kiệm
            SavingAccount savingAccount = new SavingAccount(2000, 0.05f);
            savingAccount.Deposit(500);
            savingAccount.Withdraw(300);
            Console.WriteLine("Số tiền lãi là: {0}", savingAccount.Getinterest());
            Console.WriteLine("-----------------------------------------------");

            // Vấn tin gửi rút tiền 
            CheckAccount checkAccount = new CheckAccount(10, 3000);
            checkAccount.Deposit(1000);
            checkAccount.Withdraw(500);
            Console.WriteLine("Số dư hiện tại là: {0}", checkAccount.getBalance());
            Console.ReadKey();
        }
    }
}
