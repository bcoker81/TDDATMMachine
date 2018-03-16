using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Console.Models
{
    public enum EventCode
    {
        Withdraw =1, Deposit, ViewBalance
    }

    public class TransactionLog
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public EventCode EventCode { get; set; }
        public decimal Amount { get; set; }
    }
}
