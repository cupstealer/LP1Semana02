using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            //Double
            double max = double.MaxValue;
            double min = double.MinValue;
            //Int Type
            int max2 = int.MaxValue;
            int min2 = int.MinValue;
            //Short Type
            short max3 = short.MaxValue;
            short min3 = short.MinValue;
            //Sbyte Type
            sbyte max4 = sbyte.MaxValue;
            sbyte min4 = sbyte.MinValue;
            //Float Type
            float max5 = float.MaxValue;
            float min5 = float.MinValue;
            //Decimal Type
            decimal max6 = decimal.MaxValue;
            decimal min6 = decimal.MinValue;
            //Long Type
            long max7 = long.MaxValue;
            long min7 = long.MinValue;

            //Double Infinity
            double x1 = double.PositiveInfinity;
            double x2 = double.NegativeInfinity;
            //Float NAN
            float x = float.NaN;

            Console.WriteLine();
            Console.WriteLine($"Range of Int Type is {min2} to {max2}");
            Console.WriteLine($"Range of Short Type is {min3} to {max3}");
            Console.WriteLine($"Range of Sbyte Type is {min4} to {max4}");
            Console.WriteLine($"Range of Float Type is {min5} to {max5}");
            Console.WriteLine($"Range of Decimal Type is {min6} to {max6}");
            Console.WriteLine($"Range of Double Type is {min} to {max}");
            Console.WriteLine($"Range of Long Type is {min7} to {max7}");
            
            Console.WriteLine();
            Console.WriteLine($"Range of Infinity Double Type is {x1} to {x2}");
            Console.WriteLine($"The Invalid Float Type is {x}");
        }
    }
}
