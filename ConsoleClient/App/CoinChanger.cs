using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class CoinChanger
    {


        private const int quarter = 25;
        private const int dime = 10;
        private const int nickel = 5;
        private const int penny = 1;
        // private int total = 0;

        public int incrementquarter = 0;
        public int incrementdime = 0;
        public int incrementnickel = 0;
        public int incrementpenny = 0;


        public void GetTheChange(int cash)
        {
            int total = cash;
            while (total != 0)
            {
                if(Condition(total, quarter))
                {
                    incrementquarter = GetCoinIncrement(incrementquarter);
                    total = GetTotal(total, quarter);
                }
                else if (Condition(total, dime))
                {
                    incrementdime = GetCoinIncrement(incrementdime);
                    total = GetTotal(total, dime);
                }
                else if (Condition(total, nickel))
                {
                    incrementnickel = GetCoinIncrement(incrementnickel);
                    total = GetTotal(total, nickel);
                }
                else
                {
                    incrementpenny = GetCoinIncrement(incrementpenny);
                    total = GetTotal(total, penny);
                }
            }
        }

        public int GetCoinIncrement(int increment)
        {
            int numberOfCoinsincremented = 0;
            numberOfCoinsincremented = increment + 1;
            return numberOfCoinsincremented;

        }
        public int GetTotal(int total1, int coin)
        {
            int currentTotal = 0;
            currentTotal = total1 - coin;
            return currentTotal;
        }

        public bool Condition(int total2, int number)
        {
            bool total3;
            total3 = total2 >= number;
            return total3;

        }
    }
}





