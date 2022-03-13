using System;
using System.Collections.Generic;
using System.Text;

namespace GoldDiscountCalculator.Contracts
{
    interface ILoginService
    {
        bool Login(string userName, string password);
    }
}
