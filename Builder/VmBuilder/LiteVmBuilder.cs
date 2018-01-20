namespace VmBuilder
{
    public class LiteVmBuilder : BaseVmBuilder
    {
        internal override void AddPersistantDisk()
        {
            this.virtualMachine.AddPersistantDisk("lite-p-disk");
        }

        internal override void AddTemporaryDisk()
        {
            this.virtualMachine.AddTemporaryDisk("lite-t-disk");
        }

        internal override void AddNic()
        {
            this.virtualMachine.AddNic("lite-nic");
        }
    }
}
