using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class CoinChanger
    {

        int x;
        int y;
        int z;
        int u;

        int quarter = 25;
        int dime = 10;
        int nickel = 5;
        int penny = 1;
        int total = 0;
        int total1 = 0;
        int total2 = 0;
        int total3 = 0;
        int totalFinal = 0;

        public void Calculations(int number1)
        {
            total = number1 / quarter;
            x = total;
            total1 = number1 / dime;
            y = total1;
            total2 = number1 / nickel;
            z = total2;
            total3 = number1 / penny;
            u = total3;
            totalFinal = quarter * x + dime * y + nickel * z + penny * u;
        }

            public string GetResult(int number2)
        {
            if(x <= 3 & x>=0)    
            {
                /*return*/ Console.WriteLine(quarter)/*.ToString()*/;
            }
                else if (y<= 1 & y>=0)
                {
                    return dime.ToString();
                    
                }
                else if (z<=2 & z>=0)
                {
                    return nickel.ToString();
                }
                else if (u<=5 & u>= 0)
                {
                    return penny.ToString();
                }
            else if (number2 ==totalFinal)
            {
                return "Quarter " + x.ToString() + "+ Dime" + y.ToString() + "+ Nickels" + z.ToString() + " + Pennies" + u.ToString(); 
            }
            else
            {
                return "Those numbers DO NOT apply, please try again!!!";
            }
        }
        
     
                
    }
}
