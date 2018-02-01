using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SortingAlgorithms.Sorting
{
    public class MergeSort : ISorter
    {
        public String GetName()
        {
            return "Merge Sort";
        }

        public List<IComparable> Sort(List<IComparable> list)
        {
            List<List<IComparable>> output = getSplitList(list);
            while (output.Count > 1)
            {
                output = Merge(output);
            }
            return output.SelectMany(n => n).ToList();
        }

        public List<List<IComparable>> Merge(List<List<IComparable>> list)
        {
            var output = new List<List<IComparable>>();
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

        public List<IComparable> Merge(Tuple<List<IComparable>, List<IComparable>> lists)
        {
            var output = new List<IComparable>();
            int list1count = lists.Item1.Count;
            int list2count = lists.Item2.Count;

            while(list1count > 0 && list2count > 0)
            { 
                if (lists.Item1[0].CompareTo(lists.Item2[0]) < 0)
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

        public List<List<IComparable>> getSplitList(List<IComparable> list)
        {
            var output = new List<List<IComparable>>();
            foreach (int val in list)
            {
                output.Add(new List<IComparable>() { val });
            }
            return output;
        }        
    }
}
