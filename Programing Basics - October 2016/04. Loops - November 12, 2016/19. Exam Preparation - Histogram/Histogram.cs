namespace _04.Histogram
{
    using System;

    public class Histogram
    {
        //// Четвърта задача от междинния изпит на 6 март 2016. 

        //// Дадени са "n" цели числа в интервала[1…1000]. От тях някакъв процент p1 са под 200, 
        //// друг процент p2 са от 200 до 399, друг процент p3 са от 400 до 599, друг процент 
        //// p4 са от 600 до 799 и останалите p5 процента са от 800 нагоре. Да се напише програма, 
        //// която изчислява и отпечатва процентите p1, p2, p3, p4 и p5.

        //// Пример: Input: 7,    -> Output: 14.29%,    
        ////                800,             28.57%,
        ////                801,             14.29%,
        ////                250,             14.29%,
        ////                199,             28.57%
        ////                399, 
        ////                599, 
        ////                799 

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var percentUnder200 = 0;
            var percentBetween200To399 = 0;
            var percentBetween400To599 = 0;
            var percentBetween600To799 = 0;
            var percentOver800 = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    percentUnder200++;
                }
                else if (num < 400)
                {
                    percentBetween200To399++;
                }
                else if (num < 600)
                {
                    percentBetween400To599++;
                }
                else if (num < 800)
                {
                    percentBetween600To799++;
                }
                else
                {
                    percentOver800++;
                }
            }

            var under200 = percentUnder200 * (100.0 / n);
            var between200To399 = percentBetween200To399 * (100.0 / n);
            var between400To699 = percentBetween400To599 * (100.0 / n);
            var between600To799 = percentBetween600To799 * (100.0 / n);
            var over800 = percentOver800 * (100.0 / n);

            Console.WriteLine("{0:f2}%", under200);
            Console.WriteLine("{0:f2}%", between200To399);
            Console.WriteLine("{0:f2}%", between400To699);
            Console.WriteLine("{0:f2}%", between600To799);
            Console.WriteLine("{0:f2}%", over800);
        }
    }
}
