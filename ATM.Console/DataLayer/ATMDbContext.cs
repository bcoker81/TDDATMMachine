using ATM.Console.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Console.DataLayer
{
    public class ATMDbContext : DbContext
    {
        public ATMDbContext() : base("ATM")
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<TransactionLog> Logs { get; set; }
    }

}
