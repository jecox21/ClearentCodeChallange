using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterestCalculator
{
    public class Visa : ICreditCard
    {
        public double Balance { get; set; }
        public CardTypeEnum CardType { get; set; }
        public double InterestRate { get; set; }

        public Visa()
        {
            this.CardType = CardTypeEnum.Visa;
            this.InterestRate = .10;
        }

        public double TotalInterest()
        {
            return Balance * InterestRate;
        }
    }
}
