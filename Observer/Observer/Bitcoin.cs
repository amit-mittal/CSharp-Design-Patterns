namespace Observer
{
    using System;

    public class Bitcoin : CryptoCurrency
    {
        public Bitcoin(int initialValue) : base(initialValue)
        {
        }

        protected override void UpdateStateImpl(int change)
        {
            Console.WriteLine($"Change in state of bitcoin by {change}");
            this.value += change;
        }
    }
}
