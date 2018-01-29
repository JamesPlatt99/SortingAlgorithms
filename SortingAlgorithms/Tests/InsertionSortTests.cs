using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SortingAlgorithms;

namespace Tests
{
    [TestClass]
    public class InsertionSortTests
    {
        [TestMethod]
        public void TestRandomList()
        {
            var listGenerator = new SortingAlgorithms.ListGenerators.RandomListGenerator();
            var validator = new ListValidator();
            List<int> list = listGenerator.GetList(500);
            Assert.AreEqual(validator.Validate(list, new SortingAlgorithms.Sorting.InsertionSort()), true);
        }
        [TestMethod]
        public void TestDistinctRandomList()
        {
            var listGenerator = new SortingAlgorithms.ListGenerators.DistinctRandomListGenerator();
            var validator = new ListValidator();
            List<int> list = listGenerator.GetList(500);
            Assert.AreEqual(validator.Validate(list, new SortingAlgorithms.Sorting.InsertionSort()), true);
        }
        [TestMethod]
        public void TestSequentialList()
        {
            var listGenerator = new SortingAlgorithms.ListGenerators.SequentialListGenerator();
            var validator = new ListValidator();
            List<int> list = listGenerator.GetList(500);
            Assert.AreEqual(validator.Validate(list, new SortingAlgorithms.Sorting.InsertionSort()), true);
        }
    }
}
