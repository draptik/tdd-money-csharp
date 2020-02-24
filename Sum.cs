namespace TDDMoney.Tests
{
    public class Sum : Expression
    {
        public Expression Augend;
        public Expression Addend;

        public Sum(Expression augend, Expression addend)
        {
            Augend = augend;
            Addend = addend;
        }
        
        public Money Reduce(Bank bank, string to)
        {
            var amount = Augend.Reduce(bank, to).Amount 
                         + Addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }
        
        public Expression Plus(Expression addend)
        {
            return null;
        }
    }
}