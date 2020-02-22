namespace TDDMoney.Tests
{
    public abstract class Money
    {
        protected Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        protected int Amount { get; }

        public string Currency { get; }

        public abstract Money Times(int multiplier);
        
        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }
        
        public static Franc Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public override bool Equals(object? obj)
        {
            Money other = (Money) obj;
            return Amount == other.Amount
                   && this.GetType() == other.GetType();
        }
    }
}