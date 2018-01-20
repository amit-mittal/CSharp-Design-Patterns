namespace Builder
{
    using System;
    using VmBuilder;

    /// <summary>
    /// Builders and Product are kept in separate DLL
    /// to make sure that Client doesn't have permission to
    /// call methods of builder or product.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var iaasVmBuilder = new IaasVmBuilder();
            var paasVmBuilder = new PaasVmBuilder();
            VmDirector vmDirector = new VmDirector(iaasVmBuilder);

            vmDirector.ParseConfig("FPTPNFN");
            Console.WriteLine(iaasVmBuilder.GetVm().GetDetails());

            Console.ReadKey();
        }
    }
}
