using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            BankController Bank = new BankController();

            Console.WriteLine((Bank.CreateCustomer("Jay Jackson", 454545, 9838)));
        }
    }
}