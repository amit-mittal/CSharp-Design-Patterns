namespace Memento
{
    using System;

    /// <summary>
    /// Can be thought of as an Editor.
    /// </summary>
    public class Originator
    {
        private string state;

        public Originator()
        {
            this.state = "";
        }

        public Memento CreateMemento()
        {
            return new Memento(this.state);
        }

        public void SetMemento(Memento snapshot)
        {
            this.state = snapshot.GetState();
            Console.WriteLine(this.state);
        }

        public void AlterState(string newValue)
        {
            this.state += newValue;
            Console.WriteLine(this.state);
        }
    }
}
