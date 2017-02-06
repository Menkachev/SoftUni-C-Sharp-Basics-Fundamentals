namespace Operations_between_Numbers
{
    using System;

    public class OperationBetweenNumbers
    {
        public static void Main()
        {
            //// Трета задача от междинния изпит на 26 март 2016.

            //// Напишете програма, която чете две цели числа (N1 и N2) и оператор с който да се извърши дадена 
            //// математическа операция с тях. Възможните операции са: Събиране(+), Изваждане(-), Умножение(*), 
            //// Деление(/) и Модулно деление(%). При събиране, изваждане и умножение на конзолата трябва да се 
            //// отпечатат резултата и дали той е четен или нечетен.При обикновеното деление – резултата. При 
            //// модулното деление – остатъка. Трябва да се има предвид, че делителят може да е равен на 
            //// 0(нула), а на нула не се дели. В този случай трябва да се отпечата специално съобщениe.

            //// От конзолата се прочитат 3 реда:
            ////   # N1 – цяло число в интервала[0...40 000]
            ////   # N2 – цяло число в интервала[0...40 000]
            ////   # Оператор – един символ измеду: „+“, „-“, „*“, „/“, „%“

            //// Да се отпечата на конзолата един ред:
            ////   # Ако операцията е събиране, изваждене или умножение: 
            ////     „{N1} {оператор}{N2} = {резултат} – {even / odd}“
            ////   # Ако операцията е деление:
            ////     „{N1} / {N2} = {резултат}“ – резултата е фораматиран до вторият знак след дес.запетая
            ////   # Ако операцията е модулно деление: „{N1} % {N2} = {остатък}“
            ////   # В случай на деление с 0(нула): „Cannot divide {N1} by zero“

            var number1 = double.Parse(Console.ReadLine());
            var number2 = double.Parse(Console.ReadLine());
            var simbol = Console.ReadLine();

            if (simbol == "+")
            {
                var total = number1 + number2;

                {
                    Console.WriteLine(
                        "{0} {1} {2} = {3} - {4}",
                        number1,
                        simbol,
                        number2,
                        total,
                        total % 2 == 0 ? "even" : "odd");
                }
            }
            else if (simbol == "-")
            {
                var total = number1 - number2;
                {
                    Console.WriteLine(
                        "{0} {1} {2} = {3} - {4}",
                        number1,
                        simbol,
                        number2,
                        total,
                        total % 2 == 0 ? "even" : "odd");
                }
            }
            else if (simbol == "*")
            {
                var total = number1 * number2;
                {
                    Console.WriteLine(
                        "{0} {1} {2} = {3} - {4}",
                        number1,
                        simbol,
                        number2,
                        total,
                        total % 2 == 0 ? "even" : "odd");
                }
            }

            if (simbol == "/")
            {
                if (number2 != 0)
                {
                    var total = number1 / number2;
                    {
                        Console.WriteLine("{0} / {1} = {2:f2}", number1, number2, total);
                    }
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", number1);
                }
            }
            else if (simbol == "%")
            {
                if (number2 != 0)
                {
                    var total = number1 % number2;
                    {
                        Console.WriteLine("{0} % {1} = {2}", number1, number2, total);
                    }
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", number1);
                }
            }
        }
    }
}