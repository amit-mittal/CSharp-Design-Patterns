namespace Proxy
{
    public class RestrictedWebpage : IWebpage
    {
        public string Request(string authToken)
        {
            if (authToken.Equals("Unregistered-User"))
                return "Access Denied";

            return "Welcome to Wonderland!!";
        }
    }
}
