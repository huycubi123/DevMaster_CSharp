using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_1
{
    internal class SavingAccount : Account
    {
       public float rate; 
       public SavingAccount(double initialize, float rate ) : base (initialize) {
            this.rate = rate;
        }
        public double Getinterest()
        {
            return moneyLive * rate; // money đã được khai báo và khởi tạo 
        }
    }


}
