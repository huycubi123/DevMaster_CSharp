using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_1
{
    internal class CheckAccount : Account
    {
        public float FeeTransfer;
        public CheckAccount(float FeeTransfer,double Balance) : base(Balance)
        {
            this.FeeTransfer = FeeTransfer;
        }
        // Số tiền trong tài khoản sau khi trừ số tiền gửi trừ thêm phí giao dịch 
        public override void Deposit(double money)
        {
            base.Deposit(money);
            moneyLive = moneyLive - FeeTransfer;
        }

        public override void Withdraw(double money)
        {
            base.Withdraw(money);
            moneyLive = moneyLive - FeeTransfer;
        }


    }
}
