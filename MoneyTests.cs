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
            five.Times(2).Should().Be(new Dollar(10));
            five.Times(3).Should().Be(new Dollar(15));
        }

        [Fact]
        public void Franc_Multiplication()
        {
            Franc five = new Franc(5);
            five.Times(2).Should().Be(new Franc(10));
            five.Times(3).Should().Be(new Franc(15));
        }

        [Fact]
        public void Equality()
        {
            new Dollar(5).Should().Be(new Dollar(5));
            new Dollar(5).Should().NotBe(new Dollar(6));
            new Franc(5).Should().Be(new Franc(5));
            new Franc(5).Should().NotBe(new Franc(6));
            new Franc(5).Should().NotBe(new Dollar(5));
        }
        
        
    }
}