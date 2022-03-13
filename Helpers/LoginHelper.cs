using System;
using System.Collections.Generic;
using System.Text;

namespace GoldDiscountCalculator.Helpers
{
    class LoginHelper
    {
        public static string GetUserName()
        {
            var userName = IOHelper.GetInput("Please enter Username");
            return userName;
        }

        public static string GetPassword()
        {
            var password = IOHelper.GetInput("Please enter Password");
            return password;
        }
    }
}
