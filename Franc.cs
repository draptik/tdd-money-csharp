namespace TDDMoney.Tests
{
    public class Franc : Money
    {
        public Franc(int amount, string currency)
        {
            Amount = amount;
            base.currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.Franc(Amount * multiplier);
        }
    }
}