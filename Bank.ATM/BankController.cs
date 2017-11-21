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
        private BankService CreateBankService()
        {
            return new BankService();
        }

        public bool CreateCustomer(string name, int id, int pin)
        {
            return CreateBankService().BOOL_CustomerIdAvailable(id);
        }

    }
}
