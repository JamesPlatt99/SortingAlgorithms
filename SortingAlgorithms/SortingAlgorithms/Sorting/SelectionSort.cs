using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Sorting
{
    public class SelectionSort : ISorter
    {
        public String GetName()
        {
            return "Selection Sort";
        }

        public List<IComparable> Sort(List<IComparable> list)
        {
            IComparable minVal;
            int index = 0;

            for (int i = 0; i < list.Count; i++)
            {
                minVal = int.MaxValue;
                for(int j = i; j < list.Count; j++)
                {
                    if(list[j].CompareTo(minVal) < 0)
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
