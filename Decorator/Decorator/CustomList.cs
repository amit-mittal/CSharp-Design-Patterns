namespace Decorator
{
    using System;
    using System.Collections.Generic;

    public class CustomList : ICustomList
    {
        private readonly List<string> list;

        public CustomList()
        {
            this.list = new List<string>();
        }

        public virtual void AddElement(string item)
        {
            Console.WriteLine($"Adding element {item} to list.");
            this.list.Add(item);
        }

        public virtual void RemoveElement(string item)
        {
            Console.WriteLine($"Removing element {item} from list.");
            this.list.Remove(item);
        }
    }
}
