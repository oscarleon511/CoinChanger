using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App;

namespace ConsoleClient
{
    public class Program
    {
        private static CoinChanger coins;


        static void Main(string[] args)
        {
           

            for (int i = 1; i < 99; i++)

            {
                int ind = 1; 
                coins = new CoinChanger();
                coins.GetTheChange(i);
                Console.WriteLine("Quarter: " + coins.incrementquarter + " Dimes: " + coins.incrementdime + " Nickels: " + coins.incrementnickel + " Pennies: " + coins.incrementpenny  );
            }
            Console.ReadLine();
        }
    }
}
