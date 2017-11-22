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
        private static BankService bank = new BankService();

        public bool Customer_Create(string name, int id, int pin)
        {
            if (!bank.BOOL_CustomerIdAvailable(id))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError: That ID is already in use.");
                Thread.Sleep(1500);
                return false;
            }
            if(pin.ToString().Length != 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError: Pin must be 4 digits long.");
                Thread.Sleep(1500);
                return false;
            }
            return bank.CreateCustomer(name, id, pin);
        }

        public Customers Customer_Login(int id, int pin)
        {
            if (pin.ToString().Length != 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError: Pin must be 4 digits long.");
                Thread.Sleep(500);
            }

            return bank.GetCustomerById(id, pin);
        }

        public bool Account_Create(int num, int id, string type)
        {

        }
    }
}
