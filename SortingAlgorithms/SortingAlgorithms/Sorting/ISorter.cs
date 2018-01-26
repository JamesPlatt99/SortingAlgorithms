using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Sorting
{
    interface ISorter
    {
        List<int> Sort(List<int> list);
        void WriteName();
    }
}
