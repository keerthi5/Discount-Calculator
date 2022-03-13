using GoldDiscountCalculator.Contracts;
using GoldDiscountCalculator.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoldDiscountCalculator.Services
{
    public class LoginService : ILoginService
    {
        public bool Login(string userName, string password)
        {
            if (DataStore.UserName == userName && DataStore.Password == password)
            {
                return true;
            }
            return false;
        }
    }
}
