﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Sorting
{
    class InsertionSort : ISorter
    {
        public void WriteName()
        {
            Console.WriteLine("Insertion Sort");
        }
        public List<int> Sort(List<int> list)
        {
            int temp;
            for (int i = 0; i < list.Count; i++)
            {
                for(int j = i; j > 0; j--)
                {
                    if (list[j-1] > list[j])
                    {
                        temp = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }
    }
}
