using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class RandomListGenerator
    {
        public List<int> GetNewList(int length) {
            var output = new List<int>();
            var random = new Random();
            for (int i = 0; i < length; i++)
            {
                output.Add(random.Next(0, 10 * length));
            }
            return output;
        }
    }
}
