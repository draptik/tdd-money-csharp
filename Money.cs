namespace TDDMoney.Tests
{
    public abstract class Money
    {
        protected int Amount { get; set; }

        protected string currency;

        public string Currency => currency;

        public abstract Money Times(int multiplier);
        
        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount);
        }
        
        public static Franc Franc(int amount)
        {
            return new Franc(amount);
        }

        public override bool Equals(object? obj)
        {
            Money other = (Money) obj;
            return Amount == other.Amount
                   && this.GetType() == other.GetType();
        }
    }
}