using System;
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
            //Assert.AreEqual(expected, actual, errorMargin, "info msg");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))] //can be any kind of Exception
        public void ExampleHandlingAnException()
        { 
            //if an exception occurs in here, the ExpectedFunction checks if it is of the right type
        }
    }
}
