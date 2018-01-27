namespace Strategy
{
    using System;
    using System.Collections.Generic;

    class QuickSort : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("Sorting by default strategy but, faking as QuickSort!!");
            list.Sort();
        }
    }
}
