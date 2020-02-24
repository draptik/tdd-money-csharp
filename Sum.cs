namespace TDDMoney.Tests
{
    public class Sum : Expression
    {
        public Expression Augend;
        public Expression Addend;

        public Sum(Money augend, Money addend)
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
    }
}