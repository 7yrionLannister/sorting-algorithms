using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using model;

namespace SorterTest
{
    [TestClass]
    public class SorterTest
    {

        [TestMethod]
        public void BubleSortTest()
        {
            //Assert.AreEqual(expected, actual, errorMargin, "info msg");
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            List<int> ints = new List<int> { 6, 8, 2, 5, 1, 4, 9, 3 };
            Sorter.InsertionSort(ints);
            for (int i = 0; i < ints.Count; i++)
            {
                //Assert.IsTrue(ints[i] >= ints[i - 1]);
                Console.WriteLine(ints[i]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))] //can be any kind of Exception
        public void ExampleHandlingAnException()
        { 
            //if an exception occurs in here, the ExpectedFunction checks if it is of the right type
        }
    }
}
