using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showLists = ShowSortedList();
            var sorters = new List<Sorting.ISorter>(){
                new Sorting.SelectionSort(),
                new Sorting.InsertionSort(),
                new Sorting.MergeSort()
            };

            for(int i = 1; i < 31; i++)
            {
                ExecuteSorts(Convert.ToInt32(Math.Pow(2,i) -1), sorters, showLists);
            }
            
            Console.ReadLine();
        }

        static Boolean ShowSortedList()
        {
            Console.Write("Do you want to display the sorted lists? (y/n) :");
            char input = Console.ReadLine()[0];
            return input == 'y';
        }

        static void ExecuteSorts(int listLength, List<Sorting.ISorter> sorters, Boolean showSortedLists)
        {
            var generator = new RandomListGenerator();
            List<int> tmpList;
            var t = new Stopwatch();

            Console.WriteLine($"Length: {listLength}");
            foreach (Sorting.ISorter sorter in sorters)
            {
                sorter.WriteName();
                t.Restart();
                tmpList = sorter.Sort(generator.GetNewList(listLength));
                t.Stop();
                if (showSortedLists)
                {
                    DisplayList(tmpList);
                }
                Console.WriteLine($"   Time(ms) {t.ElapsedMilliseconds}");
            }
            Console.ReadLine();
            Console.WriteLine();
        }

        static void DisplayList(List<int> list)
        {
            Console.WriteLine(String.Join(',', list));
            Console.WriteLine();
        }
    }
}
