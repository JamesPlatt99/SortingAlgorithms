using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.ListGenerators
{
    public class DistinctRandomListGenerator : IListGenerator
    {
        public String GetName()
        {
            return "DistinctRandom";
        }
        public List<IComparable> GetList(int length)
        {
            var output = new List<IComparable>();
            var random = new Random();
            for (Int32 i = 0; i < length; i++)
            {
                Int32 curValue = random.Next(1, 10000);
                while (output.Exists(value => value.CompareTo(curValue)==0))
                {
                    curValue = random.Next(1, 10000);
                }
                output.Add((IComparable)curValue);
            }

            return output;
        }
    }
}
