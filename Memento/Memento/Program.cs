using System;

namespace Memento
{
    /// <summary>
    /// Implementation is not Thread Safe
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            Caretaker c = new Caretaker();

            o.AlterState("Line 1.");
            o.AlterState("Line 2.  ");
            c.TakeSnapshot(o.CreateMemento());

            o.AlterState("Line 3.");
            c.TakeSnapshot(o.CreateMemento());

            o.AlterState("Line 4.Line 5.");
            o.SetMemento(c.Undo());

            o.AlterState("Line 6.");
        }
    }
}
