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
                if (Condition(total, quarter))
                {
                    incrementquarter = CoinIncrements(incrementquarter);//incrementquarter += 1;
                    total = FinalTotal(total, quarter);

                }
                else if (Condition(total, dime))
                {
                    incrementdime = CoinIncrements(incrementdime);
                    total = FinalTotal(total, dime);
                }
                else if (Condition(total, nickel))
                {
                    incrementnickel = CoinIncrements(incrementnickel);
                    total = FinalTotal(total, nickel);
                }
                else
                {
                    incrementpenny = CoinIncrements(incrementpenny);
                    total = FinalTotal(total, penny);
                }

            }


        }
        private int CoinIncrements(int coinsToIncrement)
        {
            return coinsToIncrement += 1;
        }

        private int FinalTotal(int oldTotal, int coin)
        {
            int actualTotal = 0;

            actualTotal = oldTotal - coin;

            return actualTotal;
        }

        private bool Condition(int number, int coin)
        {

            bool numberProcessed;
            numberProcessed = number >= coin;
            return numberProcessed;


        }


    }

}

