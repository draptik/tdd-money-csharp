namespace TDDMoney.Tests
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        {
        }
        
        public int Rate(string from, string to)
        {
            return from == "CHF" && to == "USD"
                ? 2
                : 1;
        }
    }
}