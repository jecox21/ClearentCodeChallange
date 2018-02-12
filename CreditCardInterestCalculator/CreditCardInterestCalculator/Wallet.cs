using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterestCalculator
{
    public class Wallet
    {
        public Wallet()
        {
            this.CreditCards = new List<ICreditCard>();
        }
        public string Name { get; set; }
        public IList<ICreditCard> CreditCards { get; set; }
       
        public double TotalInterest()
        {
            double totalInterest = 0;
            foreach (ICreditCard card in CreditCards)
            {
                totalInterest += card.TotalInterest();
            }
            return totalInterest;
        }
    }
}
