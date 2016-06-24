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
            coins = new CoinChanger();
            //coins.GetTheChange();
        }
    }
}
