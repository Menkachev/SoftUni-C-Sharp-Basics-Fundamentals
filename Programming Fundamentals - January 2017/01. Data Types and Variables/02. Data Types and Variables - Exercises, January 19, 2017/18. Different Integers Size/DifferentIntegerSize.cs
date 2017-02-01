namespace _18.Different_Integers_Size
{
    using System;
    using System.Numerics;

    public class DifferentIntegerSize
    {
        //// Given an input integer, you must determine which primitive data types 
        //// are capable of properly storing that input.

        public static void Main()
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            bool ifSbyte = (num >= -128) && (num <= 127);
            bool ifByte = (num >= 0) && (num <= 255);
            bool ifShort = (num >= -32768) && (num <= 32767);
            bool ifUshort = (num >= 0) && (num <= 65535);
            bool ifInt = (num >= -2147483648) && (num <= 2147483647);
            bool ifUint = (num >= 0) && (num <= 4294967295);
            bool ifLong = (num >= -9223372036854775808) && (num <= 9223372036854775807);

            if (ifByte || ifByte || ifShort || ifUshort || ifInt || ifUint || ifLong)
            {
                Console.WriteLine("{0} can fit in:", num);

                if (ifSbyte)
                {
                    Console.WriteLine("* sbyte");
                }

                if (ifByte)
                {
                    Console.WriteLine("* byte");
                }

                if (ifShort)
                {
                    Console.WriteLine("* short");
                }

                if (ifUshort)
                {
                    Console.WriteLine("* ushort");
                }

                if (ifInt)
                {
                    Console.WriteLine("* int");
                }

                if (ifUint)
                {
                    Console.WriteLine("* uint");
                }

                if (ifLong)
                {
                    Console.WriteLine("* long");
                }
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", num);
            }
        }
    }
}