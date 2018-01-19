namespace Memento
{
    using System.Collections.Generic;

    /// <summary>
    /// Tracks the history of Editor.
    /// </summary>
    public class Caretaker
    {
        private readonly List<Memento> mementos;

        public Caretaker()
        {
            this.mementos = new List<Memento>();
        }

        public void TakeSnapshot(Memento snapshot)
        {
            this.mementos.Add(snapshot);
        }

        public Memento Undo()
        {
            int lastIndex = this.mementos.Count - 1;
            Memento snapshot = this.mementos[lastIndex];
            this.mementos.RemoveAt(lastIndex);

            return snapshot;
        }
    }
}
