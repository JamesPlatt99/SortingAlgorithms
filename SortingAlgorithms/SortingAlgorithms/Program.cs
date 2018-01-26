using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new RandomListGenerator();
            var sorters = new List<Sorting.ISorter>(){
                new Sorting.SelectionSort(),
                new Sorting.InsertionSort(),
                new Sorting.MergeSort()
            };
            List<int> list = generator.GetNewList(10);
            List<int> tmpList;

            foreach(Sorting.ISorter sorter in sorters)
            {
                sorter.WriteName();
                tmpList = sorter.Sort(generator.GetNewList(10));
                DisplayList(tmpList);
            }                   
            Console.ReadLine();
        }

        static void DisplayList(List<int> list)
        {
            foreach(int val in list)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine();
        }
    }
}
