namespace TDDMoney.Tests
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            // More ugliness:
            if (source.GetType() == typeof(Money))
            {
                return (Money) source;
            }

            Sum sum = (Sum) source; // <- Ugly cast!
            return sum.Reduce(to);
        }
    }
}