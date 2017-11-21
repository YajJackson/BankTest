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

            Console.Write("New Account Information \n"+
                              "Name: ");
            string userName = Console.ReadLine();
            Console.Write("ID: ");
            int userId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pin: ");
            int userPin = Convert.ToInt32(Console.ReadLine());

            Bank.CreateCustomer(userName, userId, userPin);
        }
    }
}