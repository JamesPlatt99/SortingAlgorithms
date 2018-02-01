using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class ListValidator
    {
        public bool Validate(List<IComparable> list, SortingAlgorithms.Sorting.ISorter sorter)
        {
            list = sorter.Sort(list);
            for(int i = 1; i < list.Count; i++)
            {
                if(list[i].CompareTo(list[i - 1]) < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
