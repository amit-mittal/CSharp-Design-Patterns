namespace Observer
{
    using System;

    public class Miner : User
    {
        public Miner(CryptoCurrency currency) : base(currency)
        {
        }

        public override void Notify()
        {
            Console.WriteLine($"Got notification in Miner!! Value {this.currency.Value}");
        }
    }
}
