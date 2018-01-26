using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms.Sorting
{
    class QuickSort : ISorter
    {
        public void WriteName()
        {
            Console.WriteLine("Quick Sort");
        }

        public List<int> Sort(List<int> list)
        {
            Pivot pivot = new Pivot(list);
            return pivot.ToList();
        }

        private class Pivot
        {
            int _value = 1;
            List<int> _left = new List<int>();
            List<int> _right = new List<int>();

            Pivot _leftPivot;
            Pivot _rightPivot;

            public Pivot(List<int> list)
            {
                _value = list[0];
                list.Remove(list[0]);
                Add(list);

                if (_left.Any())
                {
                    _leftPivot = new Pivot(_left);
                }
                if (_right.Any())
                {
                    _rightPivot = new Pivot(_right);
                }
            }

            private void Add(int value)
            {
                if (value <= _value)
                {
                    _left.Add(value);
                }
                else
                {
                    _right.Add(value);
                }
            }

            private void Add(IEnumerable<int> values)
            {
                foreach (int value in values)
                {
                    Add(value);
                }
            }

            public List<int> ToList()
            {
                var output = new List<int>();
                if(_leftPivot != null)
                {
                    output.AddRange(_leftPivot.ToList());
                }
                output.Add(_value);

                if (_rightPivot != null)
                {
                    output.AddRange(_rightPivot.ToList());
                }
                
                return output;
            }
        }
    }    
}
