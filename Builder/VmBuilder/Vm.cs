namespace VmBuilder
{
    using System.Collections.Generic;

    public class Vm
    {
        private readonly List<string> persistedDisks;
        private readonly List<string> temporaryDisks;
        private readonly List<string> nics;

        public Vm()
        {
            this.persistedDisks = new List<string>();
            this.temporaryDisks = new List<string>();
            this.nics = new List<string>();
        }

        internal void AddPersistantDisk(string diskName)
        {
            this.persistedDisks.Add(diskName);
        }

        internal void AddTemporaryDisk(string diskName)
        {
            this.temporaryDisks.Add(diskName);
        }

        internal void AddNic(string nic)
        {
            this.nics.Add(nic);
        }

        public string GetDetails()
        {
            string s = string.Join(",", this.persistedDisks) + 
                       ";" +
                       string.Join(",", this.temporaryDisks) +
                       ";" +
                       string.Join(",", this.nics);

            return s;
        }
    }
}
