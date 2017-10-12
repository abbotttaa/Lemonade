using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Market
    {
        //member variables
        double price;
        int quantity;
        //constructor
        //member methods
        public void GoToMarket(Player player)
        {
            DoYouWantLemons(player);
            DoYouWantCups(player);
            DoYouWantSugar(player);
            DoYouWantIce(player);                       
        }
        public void DoYouWantLemons(Player player)
        {
            Console.WriteLine("Do you want to buy lemons? Yes(1) or No(2)");
            string responce = Console.ReadLine();
            if(responce == "1")
            {
                PurchaseLemons(player);
                DoYouWantCups(player);
            }
            else
            {
                DoYouWantCups(player);
            }
        }
        public void DoYouWantCups(Player player)
        {
            Console.WriteLine("Do you want to buy cups? Yes(1) or No(2)");
            string responce = Console.ReadLine();
            if (responce == "1")
            {
                PurchaseCups(player);
                DoYouWantSugar(player);
            }
            else
            {
                DoYouWantSugar(player);
            }
        }
        public void DoYouWantSugar(Player player)
        {
            Console.WriteLine("Do you want to buy sugar? Yes(1) or No(2)");
            string responce = Console.ReadLine();
            if (responce == "1")
            {
                PurchaseSugar(player);
                DoYouWantIce(player);
            }
            else
            {
                DoYouWantIce(player);
            }
        }
        public void DoYouWantIce(Player player)
        {
            Console.WriteLine("Do you want to buy ice? Yes(1) or No(2)");
            string responce = Console.ReadLine();
            if (responce == "1")
            {
                PurchaseIce(player);
            }           
        }

        public void PurchaseLemons(Player player)
        {
            Console.WriteLine("How many lemons do you want to buy? They're $0.25 each.");
            int quantity = Int32.Parse(Console.ReadLine());
            int i;
            double price = .25;
            bool balanceCheck = player.piggybank.BalanceChecker(price, quantity);
            if (balanceCheck == true)
            {
                for (i = 0; i < quantity; i++)
                {
                    player.stock.lemons.Add(new Lemon());
                    player.piggybank.money -= price;
                }
            }
        }
        public void PurchaseCups(Player player)
        {
            Console.WriteLine("How many cups do you want to buy? They come in packs of 20, for $1.35 each.");
            int quantity = Int32.Parse(Console.ReadLine());
            int i;
            double price = 1.35;
            bool balanceCheck = player.piggybank.BalanceChecker(price, quantity);
            if (balanceCheck == true)
            {
                for (i = 0; i < quantity; i++)
                {
                    player.stock.cups.Add(new Cups());
                    player.piggybank.money -= price;
                }
            }
        }
        public void PurchaseSugar(Player player)
        {
            Console.WriteLine("How many sugar cubes do you want to buy? They come in packs of 5, for $0.55 each.");
            int quantity = Int32.Parse(Console.ReadLine());
            int i;
            double price = .55;
            bool balanceCheck = player.piggybank.BalanceChecker(price, quantity);
            if (balanceCheck == true)
            {
                for (i = 0; i < quantity; i++)
                {
                    player.stock.sugar.Add(new Sugar());
                    player.piggybank.money -= price;
                }
            }
        }
        public void PurchaseIce(Player player)
        {
            Console.WriteLine("How much ice do you want to buy? Bags have 10 portions, and are sold for $0.99 each.");
            int quantity = Int32.Parse(Console.ReadLine());
            int i;
            double price = .99;
            bool balanceCheck = player.piggybank.BalanceChecker(price, quantity);
            if (balanceCheck == true)
            {
                for (i = 0; i < quantity; i++)
                {
                    player.stock.ice.Add(new Ice());
                    player.piggybank.money -= price;
                }
            }
        }
        



    }
}
