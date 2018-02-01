using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms.Sorting
{
    public class QuickSort : ISorter
    {
        public String GetName()
        {
            return "Quick Sort";
        }

        public List<IComparable> Sort(List<IComparable> list)
        {
            Pivot pivot = new Pivot(list);
            return pivot.ToList();
        }

        private class Pivot
        {
            IComparable _value = 1;
            List<IComparable> _left = new List<IComparable>();
            List<IComparable> _right = new List<IComparable>();

            Pivot _leftPivot;
            Pivot _rightPivot;

            public Pivot(List<IComparable> list)
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
                if (value.CompareTo( _value) <= 0)
                {
                    _left.Add(value);
                }
                else
                {
                    _right.Add(value);
                }
            }

            private void Add(IEnumerable<IComparable> values)
            {
                foreach (int value in values)
                {
                    Add(value);
                }
            }

            public List<IComparable> ToList()
            {
                var output = new List<IComparable>();
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
