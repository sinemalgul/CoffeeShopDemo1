using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopDemo1
{
    interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
