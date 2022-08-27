using CoffeeShopCustomerManagementSystem.Abstract;
using CoffeeShopCustomerManagementSystem.Adapters;
using CoffeeShopCustomerManagementSystem.Concrete;
using CoffeeShopCustomerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopCustomerManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1995,5,7),FirstName="Rabia",LastName="Çobanlı",NationalityId="12345678910"});
            Console.ReadLine();
        }
    }
}
