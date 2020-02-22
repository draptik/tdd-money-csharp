namespace TDDMoney.Tests
{
    public abstract class Money
    {
        protected internal int Amount { get; set; }

        public abstract Money Times(int multiplier);
        
        public static Dollar Dollar(int amount)
        {
            return new Dollar(5);
        }

        public override bool Equals(object? obj)
        {
            Money other = (Money) obj;
            return Amount == other.Amount
                   && this.GetType() == other.GetType();
        }
    }
}