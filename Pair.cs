namespace TDDMoney.Tests
{
    public class Pair
    {
        private string _from;
        private string _to;

        public Pair(string from, string to)
        {
            _from = from;
            _to = to;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            
            var other = (Pair) obj;
            return _from == other._from
                   && _to == other._to;
        }

        public override int GetHashCode()
        {
            // terrible hash code, but it gets us up and running quickly
            return 0;
        }
    }
}