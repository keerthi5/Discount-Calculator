using GoldDiscountCalculator.Contracts;
using GoldDiscountCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoldDiscountCalculator.Services
{
    class CalculationService : ICalculatorService
    {
        public double CalculatePrice(Gold gold)
        {
            double totalAmount = gold.PriceVal * gold.WeightVal;
            return Convert.ToDouble(totalAmount - (gold.DiscountVal * totalAmount / 100));
        }
    }
}
