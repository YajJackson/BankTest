using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    class BankService
    {
        private readonly int _userId;

        public BankService(int userId)
        {
            _userId = userId;
        }

        public IEnumerable<Customers> GetCustomers()
        {
            using (var ctx = new BankDBEntities())
            {
                return ctx.Customers;
            }
        }

        public bool CreateCustomer(string name, int pin)
        {
            using (var ctx = new BankDBEntities())
            {
                var entity =
                    new Customers
                    {
                        CustomerID = _userId,
                        CustomerName = name,
                        CustomerPin = pin
                    };

                ctx.Customers.Add(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
