namespace PipesInPool
{
    using System;

    public class PipesInPool
    {
                            //// Втора задача от междинния изпит на 26 март 2016. 
        //// Басейн с обем V има две тръби от които се пълни.Всяка тръба има определен дебит(литрите вода
        //// минаващи през една тръба за един час). Работникът пуска тръбите едновременно и излиза за N часа.
        //// Напишете програма, която изкарва състоянието на басейна, в момента, когато работникът се върне.

        public static void Main()
        {
            var volumeOfPool = int.Parse(Console.ReadLine());
            var firstPipe = int.Parse(Console.ReadLine());
            var secondPipe = int.Parse(Console.ReadLine());
            var missing = double.Parse(Console.ReadLine());

            var persentFull = (firstPipe * missing) + (secondPipe * missing);

            if (persentFull <= volumeOfPool)
            {
               Console.WriteLine(
                    "The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", 
                    Math.Truncate(persentFull / volumeOfPool * 100), 
                    Math.Truncate(firstPipe * missing / persentFull * 100), 
                    Math.Truncate(secondPipe * missing / persentFull * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", missing, persentFull - volumeOfPool);
            }
        }
    }
}