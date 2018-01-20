namespace VmBuilder
{
    public class IaasVmBuilder : BaseVmBuilder
    {
        internal override void AddPersistantDisk()
        {
            this.virtualMachine.AddPersistantDisk("iaas-p-disk");
        }

        internal override void AddTemporaryDisk()
        {
            this.virtualMachine.AddTemporaryDisk("iaas-t-disk");
        }

        internal override void AddNic()
        {
            this.virtualMachine.AddNic("iaas-nic");
        }
    }
}
