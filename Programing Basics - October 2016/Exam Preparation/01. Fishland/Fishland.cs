namespace _01.Fishland
{
    using System;

    public class Fishland
    {
        public static void Main(string[] args)
        {
            var skumriaPrice = double.Parse(Console.ReadLine());
            var cacaPrice = double.Parse(Console.ReadLine());
            var palamudKg = double.Parse(Console.ReadLine());
            var safridKg = double.Parse(Console.ReadLine());
            var midiKg = int.Parse(Console.ReadLine());

            var palamudPrice = palamudKg * (skumriaPrice + (skumriaPrice * 0.60));
            var safridPrice = safridKg * (cacaPrice + (cacaPrice * 0.80));
            var midiPrice = midiKg * 7.50;

            Console.WriteLine("{0:f2}", palamudPrice + safridPrice + midiPrice);
        }
    }
}