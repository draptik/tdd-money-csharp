namespace TDDMoney.Tests
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            Amount = amount;
        }

        public Money Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }
    }
}