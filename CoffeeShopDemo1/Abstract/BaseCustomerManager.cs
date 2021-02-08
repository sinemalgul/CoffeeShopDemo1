using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopDemo1
{
    abstract class BaseCustomerManager:ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to db : " + customer.FirstName);
        }

    }
}
