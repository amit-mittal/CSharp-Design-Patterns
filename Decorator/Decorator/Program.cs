namespace Decorator
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            ICustomList threadSafeCustomList = new ThreadSafeCustomList();
            ICustomList customList = new CustomList();
            List<string> items = new List<string>()
            {
                "Hello",
                "World",
                "1",
                "2",
                "3",
                "10",
                "13",
                "423"
            };

            Parallel.ForEach(items, (item) =>
            {
                threadSafeCustomList.AddElement(item);
            });

            Console.WriteLine("=====");

            foreach (string item in items)
            {
                customList.AddElement(item);
            }

            Console.ReadKey();
        }
    }
}
