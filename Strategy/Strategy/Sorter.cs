namespace Strategy
{
    using System;
    using System.Collections.Generic;

    public class Sorter
    {
        private ISortStrategy sortStrategy;

        public void SetSortingStrategy(ISortStrategy v)
        {
            this.sortStrategy = v;
        }

        public void Sort(List<int> list)
        {
            if(this.sortStrategy == null)
                throw new Exception("SortingStrategy has not been set!!");
            this.sortStrategy.Sort(list);
        }
    }
}
