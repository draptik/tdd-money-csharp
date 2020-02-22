using FluentAssertions;
using Xunit;

namespace TDDMoney.Tests
{
    public class MoneyTests
    {
        [Fact]
        public void Test1()
        {
            (1 + 1).Should().Be(2);
        }
    }
}