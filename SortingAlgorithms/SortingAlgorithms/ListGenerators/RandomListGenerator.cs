using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.ListGenerators
{
    public class RandomListGenerator : IListGenerator
    {
        public String GetName()
        {
            return "Random";
        }
        public List<IComparable> GetList(int length) {
            var output = new List<IComparable>();
            var random = new Random();
            for (int i = 0; i < length; i++)
            {
                output.Add(random.Next(0, 10 * length));
            }
            return output;
        }        
    }
}
