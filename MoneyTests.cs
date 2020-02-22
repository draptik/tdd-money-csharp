using FluentAssertions;
using Xunit;

namespace TDDMoney.Tests
{
    public class MoneyTests
    {
        [Fact]
        public void Multiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            product.Amount.Should().Be(10);
            product = five.Times(3);
            product.Amount.Should().Be(15);
        }

        [Fact]
        public void Equality()
        {
            new Dollar(5).Should().Be(new Dollar(5));
            new Dollar(5).Should().NotBe(new Dollar(6));
        }
    }
}