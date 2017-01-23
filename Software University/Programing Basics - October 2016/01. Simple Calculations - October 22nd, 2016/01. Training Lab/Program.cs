using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var wInSm = w * 100;
            var hInSm = h * 100;
            var hWithoutCorridoe = hInSm - 100;
            var descks = Math.Floor(hWithoutCorridoe / 70);
            var rows = Math.Floor(wInSm / 120);

            var allDescks = (descks * rows) - 3;

            Console.WriteLine("{0:f0}", allDescks);
        }
    }
}
