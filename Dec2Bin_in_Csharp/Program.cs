using System;

namespace Dec2Bin_in_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            uint decVal, divRes;
            int count = 0, zeroCount = 0;
            string binVal = String.Empty, method = String.Empty;

            Console.WriteLine("Enter a decimal value:");
            while (!uint.TryParse(Console.ReadLine(), out decVal))
            {
                Console.WriteLine(Environment.NewLine + "Value that you have provided is not a positive integer. Please try again." + Environment.NewLine + "Enter a decimal value you wish to convert to binary:");
            }
            divRes = decVal;

            while(!(String.Equals(method, "a")) && !(String.Equals(method, "i")))
            {
                Console.WriteLine(Environment.NewLine + "Tell me which conversion option do you want to use." + Environment.NewLine + "Type \"a\" for algorithm." + Environment.NewLine + "Type \"i\" for inbuilt \"format\" function.");
                method = Console.ReadLine().ToLower();
            }

            if (String.Equals(method, "i"))
            {
                binVal = Convert.ToString(decVal, 2);
            }
            else
            {
                while (divRes > 0)
                {   
                    binVal = (divRes % 2).ToString() + binVal;
                    divRes = divRes / 2;
                }
                count = binVal.Length;
                count = count % 8;
                if (count > 0)
                {
                    //Adding leading zeroes to the string to have full "full bites"
                    zeroCount = 8 - count;
                    for (int i = 0; i < zeroCount; i++)
                    {
                        binVal = "0" + binVal;
                    }
                }
            }
            Console.WriteLine(Environment.NewLine + "Decimal value " + decVal + " converted to binary equals:" + Environment.NewLine + binVal);
        }
    }
}
