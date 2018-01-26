namespace Strategy
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            VmDeployer vmDeployer = new VmDeployer(new Azure());
            vmDeployer.DeployVm();

            Console.ReadKey();
        }
    }
}
