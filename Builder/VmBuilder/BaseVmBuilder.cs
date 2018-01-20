namespace VmBuilder
{
    public abstract class BaseVmBuilder
    {
        protected readonly Vm virtualMachine;

        protected BaseVmBuilder()
        {
            this.virtualMachine = new Vm();
        }

        public Vm GetVm()
        {
            return virtualMachine;
        }

        internal abstract void AddPersistantDisk();

        internal abstract void AddTemporaryDisk();

        internal abstract void AddNic();
    }
}
