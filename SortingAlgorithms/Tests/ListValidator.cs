using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class ListValidator
    {
        public bool Validate(List<int> list, SortingAlgorithms.Sorting.ISorter sorter)
        {
            list = sorter.Sort(list);
            for(int i = 1; i < list.Count; i++)
            {
                if(list[i] < list[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
