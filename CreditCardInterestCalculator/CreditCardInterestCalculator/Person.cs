using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterestCalculator
{
    public class Person
    {
        public Person()
        {
            this.Wallets = new List<Wallet>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }

        public IList<Wallet> Wallets { get; set; }

        public double TotalInterest()
        {
            double totalInterest = 0;
            foreach (Wallet wallet in Wallets)
            {
                totalInterest += wallet.TotalInterest();
            }
            return totalInterest;
        }

    }
}
