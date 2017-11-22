using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bank.ATM
{
    public static class UserOperation
    {
        private static BankController bank = new BankController();

        public static void UserCreate()
        {
            int inputId;
            int inputPin;
            string inputName;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("New User Information \n" +
                              "Name: ");
            try
            {
                inputName = Console.ReadLine();
                
                if (String.IsNullOrWhiteSpace(inputName))
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError: Names must be more than one character");
                Thread.Sleep(1500);
                UserCreate();
                throw;
            }
            Console.Write("ID: ");
            try
            {
                inputId = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Please enter a valid ID");
                Thread.Sleep(1500);
                UserCreate();
                throw;
            }
            Console.Write("Pin: ");
            try
            {
                inputPin = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Please enter a valid Pin");
                Thread.Sleep(1500);
                UserCreate();
                throw;
            }

            if (bank.Customer_Create(inputName, inputId, inputPin))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nNew user successfully created.");
                Thread.Sleep(1500);
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nError: Create attempt failed.");
                Thread.Sleep(1500);
                UserCreate();
            }
        }

        public static User UserLogin()
        {
            int inputId;
            int inputPin;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Enter Login Information \n" +
                          "ID: ");
            try
            {
                inputId = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Please enter a valid ID");
                Thread.Sleep(1500);
                
                UserLogin();
                throw;
            }
            
            Console.Write("Pin: ");
            try
            {
                inputPin = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Please enter a valid Pin");
                Thread.Sleep(1500);
                UserLogin();
                throw;
            }

            var currentUser = bank.Customer_Login(inputId, inputPin);

            if(currentUser != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nSuccessfully logged in, {currentUser.CustomerName}.");
                Thread.Sleep(1500);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nError: Login attempt failed.");
                Thread.Sleep(1500);
                UserLogin();
            }
            return new User
                {
                    LoggedIn = true,
                    Name = currentUser.CustomerName,
                    UserID = currentUser.CustomerID
                };
        }
    }
}
