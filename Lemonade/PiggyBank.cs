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
        public double money;
        //constructor
        //member method
        public void BalanceChecker(Player player)
        {
            if (player.piggybank.money < (quantity * price))
            {
                Console.WriteLine("Sorry buddy, you dont have the money to make that purchase. Your balance sits at $" + player.piggybank.money + ".");
            }
            else
            {
            }
        }
}
