using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.ListGenerators
{
    interface IListGenerator
    {
        List<IComparable> GetList(int length);
        String GetName();
    }
}
