using GoldDiscountCalculator.Helpers;
using GoldDiscountCalculator.Models;
using GoldDiscountCalculator.Services;
using System;

namespace GoldDiscountCalculator
{
    class Client
    {
        static void Main()
        {
            bool isLoginSuccessful;
            do
            {
                string userName = LoginHelper.GetUserName();
                string password = LoginHelper.GetPassword();
                var loginService = new LoginService();
                isLoginSuccessful = loginService.Login(userName, password);
            } while (!isLoginSuccessful);

            var getGoldPrice = CalculatorHelper.GetGoldValue();
            var getGoldWeight = CalculatorHelper.GetGoldWeight();
            var getGoldDiscount = CalculatorHelper.GetDiscount();

            var goldModel = new Gold()
            {
                PriceVal = getGoldPrice,
                WeightVal = getGoldWeight,
                DiscountVal = getGoldDiscount
            };

            var calculatorService = new CalculationService();
            var priceAfterDiscount = calculatorService.CalculatePrice(goldModel);

            Console.WriteLine(priceAfterDiscount);
        }
    }
}

