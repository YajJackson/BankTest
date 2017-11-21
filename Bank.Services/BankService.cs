﻿using Bank.Models;
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
                var entity =
                    new Customers
                    {
                        CustomerName = name,
                        CustomerID = id,
                        CustomerPin = pin
                    };

                ctx.Customers.Add(entity);

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
    }
}