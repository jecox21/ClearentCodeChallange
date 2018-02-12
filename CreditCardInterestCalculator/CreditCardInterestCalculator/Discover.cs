using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterestCalculator
{
    public class Discover : ICreditCard
    {
        public double Balance { get; set; }
        public CardTypeEnum CardType { get; set; }
        public double InterestRate { get; set; }

        public Discover()
        {
            this.CardType = CardTypeEnum.Discover;
            this.InterestRate = .01;
        }

        public double TotalInterest()
        {
            return Balance * InterestRate;
        }
    }
}