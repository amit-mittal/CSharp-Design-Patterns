namespace ChainOfResponsibility
{
    public class Request
    {
        public int RequestId { get; }

        public Request(int requestId)
        {
            this.RequestId = requestId;
        }

        public override string ToString()
        {
            return RequestId.ToString();
        }
    }
}
