using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lemonade
{
    public class Market
    {
        //member variables
        double price;
        int quantity;
        SqlConnection sql = new SqlConnection();
        //constructor
        //member methods
        public void GoToMarket(Player player)
        {
            DoYouWantLemons(player);
            DoYouWantCups(player);
            DoYouWantSugar(player);
            DoYouWantIce(player);
            GetEverythingYouNeed(player);                       
        }
        public void GetEverythingYouNeed(Player player)
        {
            Console.WriteLine("Do you have everything you need, or should you go back in the market? I have everything(1) or back to the market(2)");
            string response = Console.ReadLine();
            if (response == "2")
            {
                GoToMarket(player);

            }
            else if(response != "1" && response != "2")
            {
                Console.WriteLine("What? Try again dummy");
                GetEverythingYouNeed(player);
            }
            
        }
        public void DoYouWantLemons(Player player)
        {
            Console.WriteLine("Do you want to buy lemons? You have "+player.piggybank.money.ToString("C")+". Yes(1) or No(2)");
            string response = Console.ReadLine();
            if (response == "1")
            {
                PurchaseLemons(player);
            }
            else if(response != "1" && response != "2")
            {
                Console.WriteLine("What? Try again dummy");
                DoYouWantLemons(player);
            }
        }
        public void DoYouWantCups(Player player)
        {
            Console.WriteLine("Do you want to buy cups? You have "+player.piggybank.money.ToString("C")+". Yes(1) or No(2)");
            string response = Console.ReadLine();
            if (response == "1")
            {
                PurchaseCups(player);
            }
            else if (response != "1" && response != "2")
            {
                Console.WriteLine("What? Try again dummy");
                DoYouWantCups(player);
            }
        }
        public void DoYouWantSugar(Player player)
        {
            Console.WriteLine("Do you want to buy sugar? You have " + player.piggybank.money.ToString("C") + ". Yes(1) or No(2)");
            string response = Console.ReadLine();
            if (response == "1")
            {
                PurchaseSugar(player);
            }
            else if (response != "1" && response != "2")
            {
                Console.WriteLine("What? Try again dummy");
                DoYouWantSugar(player);
            }
        }
        public void DoYouWantIce(Player player)
        {
            Console.WriteLine("Do you want to buy ice? You have "+player.piggybank.money.ToString("C")+". Yes(1) or No(2)");
            string response = Console.ReadLine();
            if (response == "1")
            {
                PurchaseIce(player);
            }
            else if (response != "1" && response != "2")
            {
                Console.WriteLine("What? Try again dummy");
                DoYouWantIce(player);
            }
        }
        public void PurchaseLemons(Player player)
        {
            Console.WriteLine("How many lemons do you want to buy? They're $0.25 each.");
            string quantityInput = "";
            quantityInput = Console.ReadLine();     
            int quantity = Int32.Parse(quantityInput.ToString());
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
                Math.Round(player.piggybank.money, 2);
            }
        }
        public void PurchaseCups(Player player)
        {
            Console.WriteLine("How many cups do you want to buy? They come in packs of 20, for $1.35 each.");
            string quantityInput = "";
            quantityInput = Console.ReadLine();
            int quantity = Int32.Parse(quantityInput.ToString());
            int i;
            double price = 1.35;
            bool balanceCheck = player.piggybank.BalanceChecker(price, quantity);
            if (balanceCheck == true)
            {
                for (i = 0; i < (quantity * 20); i++)
                {
                    player.stock.cups.Add(new Cups());
                }
                for (i=0; i < quantity; i++)
                {
                    player.piggybank.money -= price;
                }
                Math.Round(player.piggybank.money, 2);
            }
        }
        public void PurchaseSugar(Player player)
        {
            Console.WriteLine("How many sugar cubes do you want to buy? They come in packs of 5, for $0.85 each.");
            string quantityInput = "";
            quantityInput = Console.ReadLine();
            int quantity = Int32.Parse(quantityInput.ToString());
            int i;
            double price = .85;
            bool balanceCheck = player.piggybank.BalanceChecker(price, quantity);
            if (balanceCheck == true)
            {
                for (i = 0; i < (quantity * 5); i++)
                {
                    player.stock.sugar.Add(new Sugar());
                }
                for (i = 0; i < quantity; i++)
                {
                    player.piggybank.money -= price;
                }
                Math.Round(player.piggybank.money, 2);
            }
        }
        public void PurchaseIce(Player player)
        {
            Console.WriteLine("How much ice do you want to buy? Bags have 10 portions, and are sold for $0.99 each.");
            string quantityInput = "";
            quantityInput = Console.ReadLine();
            int quantity = Int32.Parse(quantityInput.ToString());
            int i;
            double price = .99;
            bool balanceCheck = player.piggybank.BalanceChecker(price, quantity);
            if (balanceCheck == true)
            {
                for (i = 0; i < (quantity * 10); i++)
                {
                    player.stock.ice.Add(new Ice());
                }
                for (i = 0; i < quantity; i++)
                {
                    player.piggybank.money -= price;
                }
                Math.Round(player.piggybank.money, 2);
            }
        }
        



    }
}
