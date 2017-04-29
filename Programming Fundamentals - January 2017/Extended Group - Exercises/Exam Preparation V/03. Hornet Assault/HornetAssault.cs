namespace Exercise_3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HornetAssault
    {
        public static void Main()
        {
            var beehives = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            var hornests = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            var power = hornests.Sum();
            var currentFirstHornetIndex = 0;

            for (int i = 0; i < beehives.Length; i++)
            {
                var bees = beehives[i];

                if (bees >= power)
                {
                    beehives[i] -= power;
                    if (currentFirstHornetIndex < hornests.Length)
                    {
                        power -= hornests[currentFirstHornetIndex];
                        currentFirstHornetIndex++;
                    }
                }
                else
                {
                    beehives[i] -= power;
                }
            }

            if (beehives.Any(b => b > 0))
            {
                var result = beehives.Where(b => b > 0);
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                var result = hornests.Skip(currentFirstHornetIndex);
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}