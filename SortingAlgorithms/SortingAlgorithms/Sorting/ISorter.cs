using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Sorting
{
    public interface ISorter
    {
        List<int> Sort(List<int> list);
        String GetName();
    }
}
