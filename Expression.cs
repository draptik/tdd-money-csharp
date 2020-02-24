namespace TDDMoney.Tests
{
    public interface Expression
    {
        Money Reduce(string to);
    }
}