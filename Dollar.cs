namespace TDDMoney.Tests
{
    public class Dollar
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        private int Amount { get; }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            var other = (Dollar) obj;
            return Amount == other.Amount;
        }
    }
}