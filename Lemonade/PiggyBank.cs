using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class PiggyBank
    {
        //member variable
        public double money = 15.00;
        //constructor
        //member method
        public bool BalanceChecker(double price, int quantity)
        {
            if (money < (quantity * price))
            {
                Console.WriteLine("Sorry buddy, you dont have the money to make that purchase. Your balance sits at $" + money + ".");
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
