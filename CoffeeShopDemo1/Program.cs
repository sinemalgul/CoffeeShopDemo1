using System;

namespace CoffeeShopDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2000, 6, 22), FirstName = "Sinem", LastName = "Algül", NationalityId = "12345678901" });
            
            Console.ReadLine();

        }
    }
}
