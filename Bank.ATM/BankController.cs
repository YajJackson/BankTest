using Bank.Models;
using Bank.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bank.ATM
{
    class BankController
    {
        public bool Customer_Create(string name, int id, int pin)
        {
            var svc = new BankService();
            if (!svc.BOOL_CustomerIdAvailable(id))
            {
                Console.WriteLine("Error: That ID is already in use.");
                Thread.Sleep(500);
                return false;
            }
            if(pin.ToString().Length != 4)
            {
                Console.WriteLine("Error: Pin must be 4 digits long.");
                Thread.Sleep(500);
                return false;
            }
            return svc.CreateCustomer(name, id, pin);
        }

        public Customers Customer_Login(int id, int pin)
        {
            var svc = new BankService();
            if (pin.ToString().Length != 4)
            {
                Console.WriteLine("Error: Pin must be 4 digits long.");
                Thread.Sleep(500);
            }
            return svc.GetCustomerById(id, pin);
        }
    }
}
