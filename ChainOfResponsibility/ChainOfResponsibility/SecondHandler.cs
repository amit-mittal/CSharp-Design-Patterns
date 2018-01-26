namespace ChainOfResponsibility
{
    using System;

    class SecondHandler : BaseHandler
    {
        protected override bool HandleRequestImpl(Request r)
        {
            Random rand = new Random();
            if (rand.Next() % 2 == 0)
                return false;

            Console.WriteLine($"Handles the request {r} in SecondHandler");

            return true;
        }
    }
}
