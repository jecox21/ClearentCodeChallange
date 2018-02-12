using NUnit.Framework;
using CreditCardInterestCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTest
{
    [TestFixture]
    public class CalcTest
    {
        [Test, Description("1 Person with 1 wallet (1 MC, 1 Visa, 1 Discover) each with a $100")]
        public void TestCase1()
        {
            Person testPerson = new Person() { FirstName = "Test", LastName = "Person1" };
            Wallet wallet = new Wallet();
            testPerson.Wallets.Add(wallet);

            Visa VisaCC = new Visa();
            VisaCC.Balance = 100;
            wallet.CreditCards.Add(VisaCC);

            MasterCard MasterCC = new MasterCard();
            MasterCC.Balance = 100;
            wallet.CreditCards.Add(MasterCC);

            Discover DiscoverCC = new Discover();
            DiscoverCC.Balance = 100;
            wallet.CreditCards.Add(DiscoverCC);

            Assert.AreEqual(16, testPerson.TotalInterest());
            Assert.AreEqual(10, VisaCC.TotalInterest());
            Assert.AreEqual(5, MasterCC.TotalInterest());
            Assert.AreEqual(1, DiscoverCC.TotalInterest());
        }

        [Test, Description("1 Person with 2 wallet (Wallet 1 - 1 Visa, 1 Discover; Wallet 2 - 1 MC) each with a $100")]
        public void TestCase2()
        {
            Person testPerson = new Person() { FirstName = "Test", LastName = "Person1" };
            Wallet wallet1 = new Wallet();
            testPerson.Wallets.Add(wallet1);

            Visa VisaCC = new Visa();
            VisaCC.Balance = 100;
            wallet1.CreditCards.Add(VisaCC);

            Discover DiscoverCC = new Discover();
            DiscoverCC.Balance = 100;
            wallet1.CreditCards.Add(DiscoverCC);

            Wallet wallet2 = new Wallet();
            testPerson.Wallets.Add(wallet2);
            
            MasterCard MasterCC = new MasterCard();
            MasterCC.Balance = 100;
            wallet2.CreditCards.Add(MasterCC);

            Assert.AreEqual(16, testPerson.TotalInterest());
            Assert.AreEqual(11, wallet1.TotalInterest());
            Assert.AreEqual(5, wallet2.TotalInterest());
        }

        [Test, Description("2 People with 1 wallet each (Person 1: Wallet 1 - 1 Visa, 1 MC; Person 2: Wallet 1 - 1 Visa, 1 MC) each with a $100")]
        public void TestCase3()
        {
            Person testPerson1 = new Person() { FirstName = "Test", LastName = "Person1" };
            Person testPerson2 = new Person() { FirstName = "Test", LastName = "Person2" };
            Wallet wallet1 = new Wallet();
            testPerson1.Wallets.Add(wallet1);

            Visa VisaCCPerson1 = new Visa();
            VisaCCPerson1.Balance = 100;
            wallet1.CreditCards.Add(VisaCCPerson1);

            MasterCard MasterCCPerson1 = new MasterCard();
            MasterCCPerson1.Balance = 100;
            wallet1.CreditCards.Add(MasterCCPerson1);

            Wallet wallet2 = new Wallet();
            testPerson2.Wallets.Add(wallet2);

            Visa VisaCCPerson2 = new Visa();
            VisaCCPerson2.Balance = 100;
            wallet2.CreditCards.Add(VisaCCPerson2);

            MasterCard MasterCCPerson2 = new MasterCard();
            MasterCCPerson2.Balance = 100;
            wallet2.CreditCards.Add(MasterCCPerson2);

            Assert.AreEqual(15, testPerson1.TotalInterest());
            Assert.AreEqual(15, wallet1.TotalInterest());
            Assert.AreEqual(15, testPerson2.TotalInterest());
            Assert.AreEqual(15, wallet2.TotalInterest());
        }
    }
}
