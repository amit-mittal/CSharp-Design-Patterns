namespace Proxy
{
    public class WebProxy : IWebpage
    {
        private RestrictedWebpage webpage;

        public WebProxy()
        {
            this.webpage = new RestrictedWebpage();
        }

        public string Request(string authToken)
        {
            return this.webpage.Request("Registered-User");
        }
    }
}
