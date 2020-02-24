namespace TDDMoney.Tests
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            Sum sum = (Sum) source; // <- Ugly cast!
            return sum.Reduce(to);
        }
    }
}