using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = double.Parse(Console.ReadLine());
            var area = usd * 1.79549;

           
            Console.WriteLine("BGN = {0:F2}", area);
        }
    }
}
