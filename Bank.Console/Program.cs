using Bank.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new BankService();
            bank.CreateCustomer(100, 1122, "Myself");
        }
    }
}
