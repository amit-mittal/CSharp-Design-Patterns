namespace ChainOfResponsibility
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Setup the chain
            BaseHandler first = new FirstHandler();
            BaseHandler second = new SecondHandler();

            first.SetNextHandler(second);

            // Sending the request
            Request r = new Request(1);
            first.HandleRequest(r);

            Console.ReadKey();
        }
    }
}
