using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Sorting
{
    public interface ISorter
    {
        List<IComparable> Sort(List<IComparable> list);
        String GetName();
    }
}
