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
        public BankService()
        {

        }

        public IEnumerable<Customers> GetCustomers()
        {
            using (var ctx = new BankDBEntities())
            {
                return ctx.Customers;
            }
        }

        public Customers CreateCustomer()
        {
            using (var ctx = new BankDBEntities())
            {
                var entity = 
                    new Customers
                    {

                    }
            }
        }
    }
}
