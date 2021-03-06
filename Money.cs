namespace TDDMoney.Tests
{
    public class Money : Expression
    {
        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public int Amount { get; }

        public string Currency { get; }

        public Expression Times(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }
        
        public Expression Plus(Expression addend)
        {
            return new Sum(this, addend);
        }
        
        public Money Reduce(Bank bank, string to)
        {
            var rate = bank.Rate(Currency, to);
            return new Money(Amount / rate, to);
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
            if (obj == null) return false;
            
            Money other = (Money) obj;
            return Amount == other.Amount
                   && Currency == other.Currency;
        }
    }
}