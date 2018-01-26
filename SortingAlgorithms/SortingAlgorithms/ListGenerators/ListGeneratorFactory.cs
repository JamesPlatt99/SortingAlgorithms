using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms.ListGenerators
{
    class ListGeneratorFactory
    {
        public int listTypeCount = Enum.GetValues(typeof(Type)).Cast<int>().Max();
        public enum Type
        {
            Random = 1,
            DistinctRandom = 2,
            Sequential = 3
        }
        public IEnumerable<Type> GetTypes()
        {
            return Enum.GetValues(typeof(Type)).Cast<Type>();
        }

        public IListGenerator GetListGenerator(int type)
        {
            switch (type)
            {
                case (int)Type.Random:
                    return new RandomListGenerator();
                case (int)Type.Sequential:
                    return new SequentialListGenerator();
                case (int)Type.DistinctRandom:
                    return new DistinctRandomListGenerator();
                default:
                    return null;
            }
        }
    }
}
