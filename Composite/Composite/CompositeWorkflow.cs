namespace Composite
{
    using System;
    using System.Collections.Generic;

    public class CompositeWorkflow : IWorkflow
    {
        private string identifier;
        private List<IWorkflow> workflows;

        public CompositeWorkflow(string identifier)
        {
            this.identifier = identifier;
            this.workflows = new List<IWorkflow>();
        }

        public void Execute()
        {
            Console.WriteLine($"Executing an composite workflow having id {this.identifier}!!");
            foreach (IWorkflow workflow in this.workflows)
            {
                workflow.Execute();
            }
        }

        // Another variant is to have this method also in IWorkflow and make AtomicWorkflow throw exception.
        public void AddWorkflow(IWorkflow newWorkflow)
        {
            Console.WriteLine($"Added new workflow to composite workflow having id {this.identifier}!!");
            this.workflows.Add(newWorkflow);
        }
    }
}
