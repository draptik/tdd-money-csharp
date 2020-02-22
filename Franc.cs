namespace TDDMoney.Tests
{
    public class Franc
    {
        public Franc(int amount)
        {
            Amount = amount;
        }

        private int Amount { get; }

        public Franc Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            var other = (Franc) obj;
            return Amount == other.Amount;
        }
    }
}