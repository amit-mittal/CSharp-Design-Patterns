namespace Strategy
{
    public class VmDeployer
    {
        private readonly Cloud cloudProvider;

        public VmDeployer(Cloud c)
        {
            this.cloudProvider = c;
        }

        public void DeployVm()
        {
            this.cloudProvider.DoWork();
        }
    }
}
