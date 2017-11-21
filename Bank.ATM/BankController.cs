using Bank.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ATM
{
    class BankController
    {
        public bool CreateCustomer(string name, int id, int pin)
        {
            var svc = new BankService();
            if (!svc.BOOL_CustomerIdAvailable(id)) return false;
            if(pin.ToString().Length != 4)
            {
                Console.WriteLine("Error: Pin must be 4 digits long.");
                return false;
            }
            return svc.CreateCustomer(name, id, pin);
        }

    }
}
