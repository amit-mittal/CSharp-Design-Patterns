namespace VmBuilder
{
    public class PaasVmBuilder : BaseVmBuilder
    {
        internal override void AddPersistantDisk()
        {
            this.virtualMachine.AddPersistantDisk("paas-p-disk");
        }

        internal override void AddTemporaryDisk()
        {
            this.virtualMachine.AddTemporaryDisk("paas-t-disk");
        }

        internal override void AddNic()
        {
            this.virtualMachine.AddNic("paas-nic");
        }
    }
}
