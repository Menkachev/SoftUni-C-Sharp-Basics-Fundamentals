namespace _08.Trade_Comissions
{
    using System;

    public class TradeComissions
    {
        //// Фирма дава следните комисионни на търговците си според града, в който работят 
        //// и обема на продажбите s:

        //// Град  |  0 ≤ s ≤ 500	 |  500 < s ≤ 1 000  |  1 000 < s ≤ 10 000  |  s > 10 000
        //// Sofia |       5%	     |         7%	     |          8%	        |      12%
        //// Varna |      4.5%       |        7.5%       |          10%	        |      13%
        //// Plovdiv |    5.5%	     |         8%	     |          12%	        |      14.5%

        //// Напишете конзолна програма, която чете име на град(стринг) и обем на продажби(десетично число) 
        //// и изчислява и извежда размера на търговската комисионна според горната таблица. Резултатът да се 
        //// изведе закръглен с 2 цифри след десетичната точка. При невалиден град или обем на продажбите 
        //// (отрицателно число) да се отпечата “error”. 

        //// Пример: Input: Plovdiv, 499.99 -> Output: 27.50;   Input: Kaspichan, -50 -> Output: error

        public static void Main()
        {
            var town = Console.ReadLine();
            var sales = double.Parse(Console.ReadLine());
            var comission = 0.0;

            if (sales < 0)
            {
                Console.WriteLine("error");
            }
            else if (0 <= sales && sales <= 500)
            {
                switch (town)
                {
                    case "Sofia":
                        comission = sales * 0.05;
                        Console.WriteLine("{0:f2}", comission);
                        break;

                    case "Varna":
                        comission = sales * 0.045;
                        Console.WriteLine("{0:f2}", comission);
                        break;

                    case "Plovdiv":
                        comission = sales * 0.055;
                        Console.WriteLine("{0:f2}", comission);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (500 < sales && sales <= 1000)
            {
                switch (town)
                {
                    case "Sofia":
                        comission = sales * 0.07;
                        Console.WriteLine("{0:f2}", comission);
                        break;
                    case "Varna":
                        comission = sales * 0.075;
                        Console.WriteLine("{0:f2}", comission);
                        break;
                    case "Plovdiv":
                        comission = sales * 0.08;
                        Console.WriteLine("{0:f2}", comission);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (1000 < sales && sales <= 10000)
            {
                switch (town)
                {
                    case "Sofia":
                        comission = sales * 0.08;
                        Console.WriteLine("{0:f2}", comission);
                        break;
                    case "Varna":
                        comission = sales * 0.10;
                        Console.WriteLine("{0:f2}", comission);
                        break;
                    case "Plovdiv":
                        comission = sales * 0.12;
                        Console.WriteLine("{0:f2}", comission);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                switch (town)
                {
                    case "Sofia":
                        comission = sales * 0.12;
                        Console.WriteLine("{0:f2}", comission);
                        break;
                    case "Varna":
                        comission = sales * 0.13;
                        Console.WriteLine("{0:f2}", comission);
                        break;
                    case "Plovdiv":
                        comission = sales * 0.145;
                        Console.WriteLine("{0:f2}", comission);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
        }
    }
}