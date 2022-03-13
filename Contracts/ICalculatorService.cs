using GoldDiscountCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoldDiscountCalculator.Contracts
{
    public interface ICalculatorService
    {
        double CalculatePrice(Gold gold);
    }
}
