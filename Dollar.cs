namespace TDDMoney.Tests
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            Money other = (Money) obj;
            return Amount == other.Amount;
        }
    }
}