namespace Strategy
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Sorter sorter = new Sorter();

            sorter.SetSortingStrategy(new QuickSort());
            sorter.Sort(new List<int>(){4, 10, -1, 99, 1023, -7984, -22, 0});

            Console.ReadKey();
        }
    }
}
