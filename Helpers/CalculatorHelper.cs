using System;
using System.Collections.Generic;
using System.Text;

namespace GoldDiscountCalculator.Helpers
{
    public class CalculatorHelper
    {
        public static double GetGoldValue()
        {
            var value = IOHelper.GetInput("Please enter Gold price (per gram)");
            return Convert.ToDouble(value);
        }

        public static double GetGoldWeight()
        {
            var weight = IOHelper.GetInput("Please enter Weight of the item (in grams)");
            return Convert.ToDouble(weight);
        }

        public static double GetDiscount()
        {
            var discount = IOHelper.GetInput("Please enter Discount (in percentage)");
            return Convert.ToDouble(discount);
        }
    }
}
