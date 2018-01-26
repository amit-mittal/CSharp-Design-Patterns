namespace Observer
{
    using System;

    public class Buyer : User
    {
        public Buyer(CryptoCurrency currency) : base(currency)
        {
        }

        public override void Notify()
        {
            Console.WriteLine($"Got notification in Buyer!! Value {this.currency.Value}");
        }
    }
}
