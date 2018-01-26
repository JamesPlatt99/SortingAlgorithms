using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.ListGenerators
{
    interface IListGenerator
    {
        List<int> GetList(int length);
    }
}
