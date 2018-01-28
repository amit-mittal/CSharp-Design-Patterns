namespace Composite
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            AtomicWorkflow workflow1 = new AtomicWorkflow("Workflow_1");
            workflow1.Execute();
            Console.WriteLine("Successfully execute Workflow_1 in Client.");

            CompositeWorkflow compositeWorkflow1 = new CompositeWorkflow("CompositeWorkflow_1");
            compositeWorkflow1.AddWorkflow(new AtomicWorkflow("Workflow_2"));
            compositeWorkflow1.AddWorkflow(new AtomicWorkflow("Workflow_3"));

            CompositeWorkflow compositeWorkflow2 = new CompositeWorkflow("CompositeWorkflow_2");
            compositeWorkflow2.AddWorkflow(new AtomicWorkflow("Workflow_1"));
            compositeWorkflow2.AddWorkflow(compositeWorkflow1);

            compositeWorkflow2.Execute();
            Console.WriteLine("Successfully execute CompositeWorkflow_2 in Client.");

            Console.ReadKey();
        }
    }
}
