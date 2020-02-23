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
        public void Different_class_equality()
        {
            new Money(10, "CHF")
                .Should().Be(new Franc(10, "CHF"));
        }
    }
}