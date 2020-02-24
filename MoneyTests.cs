using FluentAssertions;
using Xunit;

namespace TDDMoney.Tests
{
    public class MoneyTests
    {
        [Fact]
        public void Multiplication()
        {
            Money five = Money.Dollar(5);
            five.Times(2).Should().Be(Money.Dollar(10));
            five.Times(3).Should().Be(Money.Dollar(15));
        }

        [Fact]
        public void Franc_Multiplication()
        {
            Money five = Money.Franc(5);
            five.Times(2).Should().Be(Money.Franc(10));
            five.Times(3).Should().Be(Money.Franc(15));
        }

        [Fact]
        public void Equality()
        {
            Money.Dollar(5).Should().Be(Money.Dollar(5));
            Money.Dollar(5).Should().NotBe(Money.Dollar(6));
            Money.Franc(5).Should().NotBe(Money.Dollar(5));
        }

        [Fact]
        public void Currency()
        {
            Money.Dollar(1).Currency.Should().Be("USD");
            Money.Franc(1).Currency.Should().Be("CHF");
        }
        
        [Fact]
        public void Simple_addition()
        {
            var five = Money.Dollar(5);
            Expression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            
            reduced.Should().Be(Money.Dollar(10));
        }

        [Fact]
        public void Plus_returns_Some()
        {
            var five = Money.Dollar(5);
            Expression result = five.Plus(five);
            Sum sum = (Sum) result;
            sum.Augend.Should().Be(five);
            sum.Addend.Should().Be(five);
        }
    }
}