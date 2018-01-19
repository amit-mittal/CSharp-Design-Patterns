namespace Memento
{
    /// <summary>
    /// Snapshot of the editor's text.
    /// </summary>
    public class Memento
    {
        private readonly string state;

        public Memento(string state)
        {
            this.state = state;
        }

        public string GetState()
        {
            return state;
        }
    }
}