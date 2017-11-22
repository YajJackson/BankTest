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

            var currentUser = BankOperation.Welcome();

            while (currentUser.LoggedIn)
            {
                currentUser.LoggedIn = !currentUser.LoggedIn;
            }

        }
    }
}