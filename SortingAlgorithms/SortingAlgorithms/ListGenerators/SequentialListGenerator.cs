using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.ListGenerators
{
    class SequentialListGenerator : IListGenerator
    {
        public List<int> GetList(int length)
        {
            var output = new List<int>();
            for (int i = 0; i < length; i++)
            {
                output.Add(i);
            }
            return output;
        }
    }
}
