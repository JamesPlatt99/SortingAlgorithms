using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SortingAlgorithms.Sorting
{
    class MergeSort : ISorter
    {
        public String GetName()
        {
            return "Merge Sort";
        }

        public List<int> Sort(List<int> list)
        {
            List<List<int>> output = getSplitList(list);
            while (output.Count > 1)
            {
                output = Merge(output);
            }
            return output.SelectMany(n => n).ToList();
        }

        public List<List<int>> Merge(List<List<int>> list)
        {
            var output = new List<List<int>>();
            int listCount = list.Count;
            while (listCount > 0)
            {
                if (listCount == 1)
                {
                    output.Add(list[0]);
                }
                else
                {
                    output.Add(Merge(Tuple.Create(list[0], list[1])));
                    list.Remove(list[0]);
                }
                list.Remove(list[0]);
                listCount -= 2;
            }

            return output;
        }

        public List<int> Merge(Tuple<List<int>, List<int>> lists)
        {
            var output = new List<int>();
            int list1count = lists.Item1.Count;
            int list2count = lists.Item2.Count;

            while(list1count > 0 && list2count > 0)
            { 
                if (lists.Item1[0] < lists.Item2[0])
                {
                    output.Add(lists.Item1[0]);
                    lists.Item1.Remove(lists.Item1[0]);
                    list1count--;
                }
                else
                {
                    output.Add(lists.Item2[0]);
                    lists.Item2.Remove(lists.Item2[0]);
                    list2count--;
                }
            }
            output = output.Concat(lists.Item1).ToList();  
            output = output.Concat(lists.Item2).ToList();
            return output;
        }

        public List<List<int>> getSplitList(List<int> list)
        {
            var output = new List<List<int>>();
            foreach (int val in list)
            {
                output.Add(new List<int>() { val });
            }
            return output;
        }        
    }
}
