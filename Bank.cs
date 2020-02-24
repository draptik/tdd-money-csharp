using System.Collections.Generic;

namespace TDDMoney.Tests
{
    public class Bank
    {
        private readonly Dictionary<Pair, int> _rates = new Dictionary<Pair, int>();
        
        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        {
            _rates.Add(new Pair(from, to), rate);
        }
        
        public int Rate(string from, string to)
        {
            if (from == to)
            {
                return 1;
            }
            
            var rate = _rates[new Pair(from, to)];
            return rate;
        }
    }
}