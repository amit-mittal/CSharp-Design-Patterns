namespace Decorator
{
    using System;

    /// <summary>
    /// Decorator class over CustomList.
    /// </summary>
    public class ThreadSafeCustomList : CustomList
    {
        private readonly Object thisLock;

        public ThreadSafeCustomList()
        {
            thisLock = new Object();
        }

        public override void AddElement(string item)
        {
            Console.WriteLine($"Taking lock for {item} to be added to thread-safe list.");
            lock (this.thisLock)
            {
                base.AddElement(item);
            }
        }

        public override void RemoveElement(string item)
        {
            Console.WriteLine($"Taking lock for {item} to be removed from thread-safe list.");
            lock (this.thisLock)
            {
                base.RemoveElement(item);
            }
        }
    }
}
