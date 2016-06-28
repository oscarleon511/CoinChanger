using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class CoinChanger
    {
        int quarter = 25;
        int dime = 10;
        int nickel = 5;
        int penny = 1;
       public int incrementquarter = 0;
       public int incrementdime = 0;
        public int incrementnickel = 0;
        public int incrementpenny = 0;

              
        

        public void GetTheChange(int cash)
        {
            int total = cash;

            while(total != 0)
            {
                if (total >= 25)
                {
                    incrementquarter += 1;
                    total -= quarter;
                }
                else if ( total >= 10)
                {
                    incrementdime++;
                    total -= dime;
                }
                else if (total >=5 )
                {
                    incrementnickel++;
                    total -= nickel;
                }
                else
                {
                    incrementpenny++;
                    total -= penny;
                }
            }
           
        }
    }
}

