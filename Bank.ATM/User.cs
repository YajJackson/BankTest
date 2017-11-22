using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ATM
{
    class User
    {
        public int UserID { get; set; }
        public bool LoggedIn { get; set; }
        public string Name { get; set; }
        public IEnumerable<Accounts> Accounts { get; set; }
    }
}
