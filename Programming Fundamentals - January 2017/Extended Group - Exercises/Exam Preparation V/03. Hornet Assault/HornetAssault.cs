namespace Exercise_3
{
    using System;
    using System.Linq;

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
                        currentFirstHornetIndex++; // When the first hornet is killed, the next one become first.
                    }
                }
                else
                {
                    beehives[i] -= power;
                }
            }

            if (beehives.Any(b => b > 0)) // If there is any alive bees.
            {
                var result = beehives.Where(b => b > 0);
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                var result = hornests.Skip(currentFirstHornetIndex); // Skip the dead hornests.
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}