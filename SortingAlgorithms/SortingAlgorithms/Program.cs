using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new RandomListGenerator();
            var selectionSorter = new Sorting.SelectionSort();
            List<int> list = generator.GetNewList(10);
                
            foreach (int val in list){
                Console.WriteLine(val);
            }

            list = selectionSorter.Sort(list);
            Console.WriteLine();
            foreach (int val in list)
            {
                Console.WriteLine(val);
            }

            Console.ReadLine();
        }
    }
}
