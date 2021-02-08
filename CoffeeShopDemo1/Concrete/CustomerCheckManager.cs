using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopDemo1
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

    }
}
