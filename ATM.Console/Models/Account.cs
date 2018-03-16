using System;
using System.ComponentModel.DataAnnotations;

namespace ATM.Console.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal CurrentBalance { get; set; }
        public DateTime AccountCreateDate { get; set; }
    }
}
