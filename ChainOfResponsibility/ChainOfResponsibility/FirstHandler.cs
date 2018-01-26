namespace ChainOfResponsibility
{
    using System;

    public class FirstHandler : BaseHandler
    {
        protected override bool HandleRequestImpl(Request r)
        {
            Random rand = new Random();
            if (rand.Next() % 2 == 0)
                return false;

            Console.WriteLine($"Handles the request {r} in FirstHandler");

            return true;
        }
    }
}
