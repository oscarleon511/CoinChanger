using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            CoinChanger display = new CoinChanger();
            display.Calculations(25);

            CoinChanger display2 = new CoinChanger();
            display2.GetResult(25);
        }
    }
}
