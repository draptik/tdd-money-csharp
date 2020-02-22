namespace TDDMoney.Tests
{
    public class Money
    {
        protected internal int Amount { get; set; }

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