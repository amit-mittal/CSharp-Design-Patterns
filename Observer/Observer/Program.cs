namespace Observer
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            CryptoCurrency bitcoin = new Bitcoin(10);
            User buyer = new Buyer(bitcoin);
            User miner = new Miner(bitcoin);

            bitcoin.UpdateState(7);
            bitcoin.UpdateState(-4);

            Console.ReadKey();
        }
    }
}
