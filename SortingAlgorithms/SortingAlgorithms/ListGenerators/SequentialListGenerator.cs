using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.ListGenerators
{
    public class SequentialListGenerator : IListGenerator
    {
        public String GetName()
        {
            return "SequentialList";
        }

        public List<IComparable> GetList(int length)
        {        
            var output = new List<IComparable>();
            for (int i = 0; i < length; i++)
            {
                output.Add(i);
            }
            return output;
        }
    }
}
