using System;

namespace Dec2Bin_in_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a decimal value:");
            //int decVal = Convert.ToInt32(Console.ReadLine());
            uint decVal;
            Console.WriteLine("Enter a decimal value:");
            while (!uint.TryParse(Console.ReadLine(), out decVal))
                Console.WriteLine(Environment.NewLine + "Value that you have provided is not a positive integer. Please try again." + Environment.NewLine + "Enter a decimal value you wish to convert to binary:");
            Console.WriteLine(Environment.NewLine + "Decimal value " + decVal + " converted to binary equals:");
            string binVal = Convert.ToString(decVal, 2);
            Console.WriteLine(binVal);
        }
    }
}
