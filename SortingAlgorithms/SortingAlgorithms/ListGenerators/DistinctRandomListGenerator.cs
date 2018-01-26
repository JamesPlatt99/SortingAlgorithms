using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.ListGenerators
{
    class DistinctRandomListGenerator : IListGenerator
    {
        public String GetName()
        {
            return "DistinctRandom";
        }
        public List<int> GetList(int length)
        {
            var output = new List<int>();
            var random = new Random();
            for (Int32 i = 0; i < length; i++)
            {
                Int32 curValue = random.Next(1, 10000);
                while (output.Exists(value => value == curValue))
                {
                    curValue = random.Next(1, 10000);
                }
                output.Add(curValue);
            }

            return output;
        }
    }
}
