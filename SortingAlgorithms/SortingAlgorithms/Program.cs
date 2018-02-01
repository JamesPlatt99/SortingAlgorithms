using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var listGenerator = listType();
                var file = new StreamWriter($"ExecutionTimes{listGenerator.GetName()}.csv");
                file.WriteLine("Name, Length, Time");
                bool showLists = ShowSortedList();
                var sorters = new List<Sorting.ISorter>(){
                    new Sorting.SelectionSort(),
                    new Sorting.InsertionSort(),
                    new Sorting.MergeSort(),
                    new Sorting.QuickSort()
                };

                for(int i = 1; i < 14; i++)
                {
                    file.WriteLine(ExecuteSorts(Convert.ToInt32(Math.Pow(2,i) -1), sorters, showLists, listGenerator));
                }
                file.Close();
            }
        }
        static Boolean ShowSortedList()
        {
            Console.Write("Do you want to display the sorted lists? (y/n) :");
            char input = Console.ReadLine()[0];
            return input == 'y';
        }
        static ListGenerators.IListGenerator listType()
        {
            var listGeneratorFactory = new ListGenerators.ListGeneratorFactory();

            Console.WriteLine("List type:");
            foreach (var type in listGeneratorFactory.GetTypes())
            {
                Console.WriteLine($" {(int) type} {type.ToString()}");
            }
            int input = 0;
            while (!int.TryParse(Console.ReadLine(), out input) && input >= 0 && input < listGeneratorFactory.listTypeCount) { }

            return listGeneratorFactory.GetListGenerator(input);
        }

        static string ExecuteSorts(int listLength, List<Sorting.ISorter> sorters, Boolean showSortedLists, ListGenerators.IListGenerator generator)
        {
            var output = new StringBuilder();
            List<IComparable> tmpList;
            var t = new Stopwatch();

            Console.WriteLine($"Length: {listLength}");
            foreach (Sorting.ISorter sorter in sorters)
            {
                
                Console.WriteLine(sorter.GetName());
                t.Restart();
                tmpList = sorter.Sort(generator.GetList(listLength));
                t.Stop();
                if (showSortedLists)
                {
                    DisplayList(tmpList);
                }
                output.AppendLine( $"{sorter.GetName()},{listLength},{t.ElapsedMilliseconds}");
                Console.WriteLine($"   Time(ms) {t.ElapsedMilliseconds}");
            }
            Console.WriteLine();
            return output.ToString();
        }

        static void DisplayList(List<IComparable> list)
        {
            Console.WriteLine(String.Join(',', list));
            Console.WriteLine();
        }
    }
}
