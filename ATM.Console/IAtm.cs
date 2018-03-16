using ATM.Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Console
{
    public interface IAtm
    {
        bool Deposit(Account account, decimal amount);
        bool Withdraw(decimal amount);
        AccountResponse CheckBalance(string accountNumber);
    }
}
