using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class QuickSortTests
    {
        [TestMethod]
        public void TestRandomList()
        {
            var listGenerator = new SortingAlgorithms.ListGenerators.RandomListGenerator();
            var validator = new ListValidator();
            List<IComparable> list = listGenerator.GetList(500);
            Assert.AreEqual(validator.Validate(list, new SortingAlgorithms.Sorting.MergeSort()), true);
        }
        [TestMethod]
        public void TestDistinctRandomList()
        {
            var listGenerator = new SortingAlgorithms.ListGenerators.DistinctRandomListGenerator();
            var validator = new ListValidator();
            List<IComparable> list = listGenerator.GetList(500);
            Assert.AreEqual(validator.Validate(list, new SortingAlgorithms.Sorting.MergeSort()), true);
        }
        [TestMethod]
        public void TestSequentialList()
        {
            var listGenerator = new SortingAlgorithms.ListGenerators.SequentialListGenerator();
            var validator = new ListValidator();
            List<IComparable> list = listGenerator.GetList(500);
            Assert.AreEqual(validator.Validate(list, new SortingAlgorithms.Sorting.MergeSort()), true);
        }
    }
}
