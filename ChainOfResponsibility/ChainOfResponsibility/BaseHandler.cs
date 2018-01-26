namespace ChainOfResponsibility
{
    using System;

    public abstract class BaseHandler
    {
        private BaseHandler nextHandler;

        protected abstract bool HandleRequestImpl(Request r);

        public void SetNextHandler(BaseHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public void HandleRequest(Request r)
        {
            bool isHandled = this.HandleRequestImpl(r);
            if (!isHandled && nextHandler != null)
            {
                Console.WriteLine($"Transferring request to next handler!!");
                this.nextHandler.HandleRequest(r);
            }
            else if (!isHandled && nextHandler == null)
            {
                Console.WriteLine($"Reached the terminal handler!!");
            }
        }
    }
}
