namespace TDDMoney.Tests
{
    public class Money
    {
        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        protected int Amount { get; }

        public string Currency { get; }

        public Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }
        
        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }
        
        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public override bool Equals(object? obj)
        {
            Money other = (Money) obj;
            return Amount == other.Amount
                   && Currency == other.Currency;
        }
    }
}