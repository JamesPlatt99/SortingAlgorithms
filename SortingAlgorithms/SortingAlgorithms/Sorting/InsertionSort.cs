using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Sorting
{
    public class InsertionSort : ISorter
    {
        public String GetName()
        {
            return "Insertion Sort";
        }

        public List<int> Sort(List<int> list)
        {
            int temp;
            for (int i = 0; i < list.Count; i++)
            {
                for(int j = i; j > 0; j--)
                {
                    if (list[j-1] > list[j])
                    {
                        temp = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }
    }
}
