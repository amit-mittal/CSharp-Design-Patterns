namespace Composite
{
    using System;

    public class AtomicWorkflow : IWorkflow
    {
        private string identifier;

        public AtomicWorkflow(string identifier)
        {
            this.identifier = identifier;
        }

        public void Execute()
        {
            Console.WriteLine($"Executing an atomic workflow having id {this.identifier}!!");
        }
    }
}
