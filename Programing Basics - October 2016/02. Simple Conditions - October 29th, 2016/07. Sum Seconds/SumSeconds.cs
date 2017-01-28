namespace Sum_Seconds
{
    using System;

    public class SumSeconds
    {
        //// Трима спортни състезатели финишират за някакъв брой секунди(между 1 и 50). Да се напише програма,
        //// която въвежда времената на състезателите и пресмята сумарното им време във формат "минути:секунди". 
        //// Секундите да се изведат с водеща нула(2 -> "02", 7 -> "07", 35 -> "35"). 

        public static void Main()
        {
            var run1 = int.Parse(Console.ReadLine());
            var run2 = int.Parse(Console.ReadLine());
            var run3 = int.Parse(Console.ReadLine());

            var sum = run1 + run2 + run3;
            var min = sum / 60;
            var sec = sum % 60;

            Console.WriteLine("{0}:{1:00}", min, sec); 
        }
    }
}