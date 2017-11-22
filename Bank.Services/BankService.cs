using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class BankService
    {
        #region Customers
        public IEnumerable<Customers> GetCustomers()
        {
            using (var ctx = new BankDBEntities())
            {
                return ctx.Customers;
            }
        }

        public bool BOOL_CustomerIdAvailable(int id)
        {
            using (var ctx = new BankDBEntities())
            {                
                return (from c in ctx.Customers where c.CustomerID == id select c).Count() == 0;
            }
        }

        public bool CreateCustomer(string name, int id, int pin)
        {
            using (var ctx = new BankDBEntities())
            {
                var newCustomer =
                    new Customers
                    {
                        CustomerName = name,
                        CustomerID = id,
                        CustomerPin = pin
                    };

                ctx.Customers.Add(newCustomer);

                return ctx.SaveChanges() == 1;
            }
        }

        public Customers GetCustomerById(int id, int pin)
        {
            return 
                new BankDBEntities()
                    .Customers
                    .SingleOrDefault(e => e.CustomerID == id && e.CustomerPin == pin);
        }
        #endregion

        #region Accounts
        public bool BOOL_AccountNumberAvailable(int id)
        {
            using (var ctx = new BankDBEntities())
            {
                return (from c in ctx.Accounts where c.AccountNumber == id select c).Count() == 0;
            }
        }

        public bool CreateAccount(int num, int id, string type)
        {
            using (var context = new BankDBEntities())
            {
                var newAccount =
                    new Accounts
                    {
                        AccountNumber = num,
                        CustomerID = id,
                        AccountType = type,
                        AccountBalance = 0
                    };

                context.Accounts.Add(newAccount);

                return context.SaveChanges() == 1;
            }
        }
        
        public Accounts GetAccountById(int num, int id)
        {
            return
                new BankDBEntities()
                    .Accounts
                    .SingleOrDefault(e => e.CustomerID == id && e.AccountNumber == num);
        }
        #endregion
    }
}