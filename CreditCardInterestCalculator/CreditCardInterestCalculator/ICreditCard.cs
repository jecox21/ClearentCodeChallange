using System;

namespace CreditCardInterestCalculator
{
    public interface ICreditCard
    {

        double Balance { get; set; }
        CardTypeEnum CardType { get; set; }
        double InterestRate { get; set; }
        double TotalInterest();
    }
}
