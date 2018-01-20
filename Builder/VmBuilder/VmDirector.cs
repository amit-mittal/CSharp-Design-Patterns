namespace VmBuilder
{
    using System.Linq;

    public class VmDirector
    {
        private readonly BaseVmBuilder vmBuilder;

        public VmDirector(BaseVmBuilder vmBuilder)
        {
            this.vmBuilder = vmBuilder;
        }

        public void ParseConfig(string config)
        {
            int persistedCount = config.Count(c => c.Equals('P'));
            int temporaryCount = config.Count(c => c.Equals('T'));
            int nicCount = config.Count(c => c.Equals('N'));

            for (int i = 0; i < persistedCount; i++)
            {
                this.vmBuilder.AddPersistantDisk();
            }

            for (int i = 0; i < temporaryCount; i++)
            {
                this.vmBuilder.AddTemporaryDisk();
            }

            for (int i = 0; i < nicCount; i++)
            {
                this.vmBuilder.AddNic();
            }
        }
    }
}
