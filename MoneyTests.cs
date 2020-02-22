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
            five.Times(2);
            five.Amount.Should().Be(10);
        }
    }
}