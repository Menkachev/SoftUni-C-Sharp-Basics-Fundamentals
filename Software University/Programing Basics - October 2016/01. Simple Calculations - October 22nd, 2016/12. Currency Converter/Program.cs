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
            var lev = 1.00000;
            var usdToBgn = 1.79549;
            var eurToBgn = 1.95583;
            var gbpToBgn = 2.53405;

            var cash = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();

            if (input != "BGN")
            {

                if (input == "USD")
                {
                    cash = cash * usdToBgn;
                }
                else if (input == "GBP")
                {
                    cash *= gbpToBgn;
                }
                else if (input == "EUR")
                {
                    cash *= eurToBgn;
                }

                if (output == "USD")
                {
                    cash /= usdToBgn;
                }
                else if (output == "GBP")
                {
                    cash /= gbpToBgn;
                }
                else if (output == "EUR")
                {
                    cash /= eurToBgn;
                }
            }

                if (input == "BGN")
                {
                    if(output == "USD")
                    {
                        cash /= usdToBgn; 
                    }
                    else if(output == "EUR")
                    {
                        cash /= eurToBgn;
                    }
                    else if(output == "GBP")
                    {
                        cash /= gbpToBgn;
                    }
                    
                }
                cash = Math.Round(cash, 2);
                Console.WriteLine(cash);
            }

        }
    }

