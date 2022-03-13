using System;
using System.Collections.Generic;
using System.Text;

namespace GoldDiscountCalculator.Helpers
{
    public class IOHelper
    {
        public static string GetInput(string Prompt)
        {
            string Result;
            do
            {
                Console.Write(Prompt + " ");
                Result = Console.ReadLine();
                if (string.IsNullOrEmpty(Result))
                {
                    Console.WriteLine("Empty input. Please enter proper value again.");
                }
            } while (string.IsNullOrEmpty(Result));

            return Result;
        }
    }
}
