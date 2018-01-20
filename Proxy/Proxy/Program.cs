namespace Proxy
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var accessToken = "Unregistered-User";
            var rw = new RestrictedWebpage();

            Console.WriteLine(rw.Request(accessToken));

            var wp = new WebProxy();

            Console.WriteLine(wp.Request(accessToken));

            Console.ReadKey();
        }
    }
}
