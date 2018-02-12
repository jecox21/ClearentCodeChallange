using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterestCalculator
{
    public class MasterCard : ICreditCard
    {
        public double Balance { get; set; }
        public CardTypeEnum CardType { get; set; }
        public double InterestRate { get; set; }

        public MasterCard()
        {
            this.CardType = CardTypeEnum.MasterCard;
            this.InterestRate = .05;
        }

        public double TotalInterest()
        {
            return Balance * InterestRate;
        }
    }
}
