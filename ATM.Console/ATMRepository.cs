using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Console.DataLayer;
using ATM.Console.Models;

namespace ATM.Console
{
    public class ATMRepository : IAtm
    {
        public bool Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public AccountResponse CheckBalance(string accountNumber)
        {
            AccountResponse response = new AccountResponse();
            try
            {
                if (accountNumber != null)
                {
                    using (var db = new ATMDbContext())
                    {
                      response.Account = db.Accounts.Where(p => p.AccountNumber == accountNumber).First();
                       return response; 
                    }
                }
                response.ErrorCode = 100;
                response.ErrorMessage = "String is null";
                response.IsSuccess = false;
                return response;
                
            }
            catch (Exception)
            {
                response.IsSuccess = false;
                response.ErrorCode = 222;
                response.ErrorMessage = $"An error occurred with account, {accountNumber}";
            }
            return null;
        }

        public bool Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
