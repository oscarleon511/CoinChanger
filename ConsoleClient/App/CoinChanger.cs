using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class CoinChanger
    {
        public string GetTheChange(int cash)
        {
            string quarter = "25";
            string dime = "10";
            string nickel = "5";
            string penny = "1";
            string result = string.Empty;
            

            int[] changeToConvert = new int[] {cash }; 
            



            for (int i = 0; i < changeToConvert.Length; i++)
            {
                if (changeToConvert[i] == 10)
                {
                    Console.WriteLine("Sample 1:");
                    Console.WriteLine("==============================================");
                    result = string.Format("This is your change {0} Cents for this amount {1} Cents",dime, changeToConvert[i]);
                    Console.WriteLine("==============================================");
                   //Console.Read();
                }
                else if (changeToConvert[i] == 35)
                {
                    Console.WriteLine("Sample 2:");
                    Console.WriteLine("==============================================");
                   result = string.Format("This is your change {0} + {1} cents for this amount {2} Cents", dime, quarter,changeToConvert[i]);
                    Console.WriteLine("==============================================");
                    //Console.Read();
                }
                else if (changeToConvert[i] == 46)
                {
                    Console.WriteLine("Sample 3:");
                    Console.WriteLine("==============================================");
                    result = string.Format("This is your change {0} + {1} + {2} + {3} cents for this amount {4} Cents", dime, quarter, dime, penny,changeToConvert[i]);
                    Console.WriteLine("==============================================");
                    //Console.Read();
                }
                else if (changeToConvert[i] == 50)
                {
                    //Console.WriteLine("Sample 4:");
                    //Console.WriteLine("==============================================");
                    result = string.Format("This is your change {0} + {1} cents for this amount {2} Cents", quarter, quarter, changeToConvert[i]);
                    //Console.WriteLine("==============================================");
                    //Console.Read();
                }
                               
                else
                {
                    //Console.WriteLine("Sample 5:");
                    //Console.WriteLine("==============================================");
                    result = string.Format("This is the current number {0} Cents", changeToConvert[i]);
                    //Console.WriteLine("==============================================");
                    //Console.Read();

                }

               
            }
            return result;
        }
    }
}

