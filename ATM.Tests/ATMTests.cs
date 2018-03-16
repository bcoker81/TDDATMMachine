using System;
using ATM.Console;
using ATM.Console.DataLayer;
using ATM.Console.Models;
using NUnit.Framework;

namespace ATM.Tests
{
    [TestFixture]
    public class ATMTests
    {
        public ATMRepository TestObj;
        private static ATMDbContext Db;

        [SetUp]
        public void Setup()
        {
            TestObj = new ATMRepository();
            Db = new ATMDbContext();
        }

        [Test]
        public void ATMLogic_ChecksBalance()
        {
            //arrange
            var expected = new Account
            {
                AccountCreateDate = DateTime.Now,
                AccountHolder = Faker.Name.FullName(),
                AccountNumber = Faker.Name.First(),
                CurrentBalance = 456.77m,
            };

            //act
            var result = Db.Accounts.Add(expected);
            Db.SaveChanges();

            var actual = TestObj.CheckBalance(expected.AccountNumber);

            //assert
            Assert.That(expected.CurrentBalance, Is.EqualTo(actual.Account.CurrentBalance));
        }

        [Test]
        public void ATMLogic_ChecksBalanceReturnsErrorMessageIfNull()
        {
            //arrange
            string expected = null;

            //act
            var actual = TestObj.CheckBalance(expected);

            //assert
            Assert.IsNotEmpty(actual.ErrorCode.ToString());
        }
    }
}
