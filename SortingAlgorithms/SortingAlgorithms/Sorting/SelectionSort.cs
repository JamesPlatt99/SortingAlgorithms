using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Sorting
{
    class SelectionSort : Sorter
    {
        public List<int> Sort(List<int> list)
        {
            int minVal;
            int index = 0;

            for (int i = 0; i < list.Count; i++)
            {
                minVal = int.MaxValue;
                for(int j = i; j < list.Count; j++)
                {
                    if(list[j] < minVal)
                    {
                        index = j;
                        minVal = list[j];
                    }
                }
                list[index] = list[i];
                list[i] = minVal;
            }
            return list;
        }


    }
}
