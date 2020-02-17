using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using model;

namespace SorterTest
{   /**
     *This class performs the ordering tests
     */
    [TestClass]
    public class SorterTest
    {   
        /**
         *Used to generate the big lists (N >= 10^2)
         */
        private static Random r = new Random(); 
        /**
         * A integer list
         */
        private List<int> ints;
        
         /**
         * Stage with a list of 10 integers in aleatory order
         */
        private void SetupStageAleatoryOrder10toThePowerOf1()
        {
            ints = new List<int> { 6, 8, 21, 5, 1, 4, 10, 23, 12, 21};
        }
        /**
         * Stage with a list of 10 integers in ascending order
         */
        private void SetupStageAscendingOrder10toThePowerOf1()
        {
            SetupStageAleatoryOrder10toThePowerOf1();
            ints.Sort();
        }
        /**
         * Stage with a list of 10 integers in decresing order
         */
        private void SetupStageDecreasingOrder10toThePowerOf1()
        {
            SetupStageAscendingOrder10toThePowerOf1();
            ints.Reverse();
        }
         
        /**
         * Stage with a list of 100 integers in aleatory order
         */
        private void SetupStageAleatoryOrder10toThePowerOf2()
        {
            FillRandomlyWith_n_Elements((int)Math.Pow(10, 2));
        }
        /**
         * Stage with a list of 100 integers in ascending order
         */
        private void SetupStageAscendingOrder10toThePowerOf2()
        {
            SetupStageAleatoryOrder10toThePowerOf2();
            ints.Sort();
        }
         /**
         * Stage with a list of 100 integers in decresing order
         */
        private void SetupStageDecreasingOrder10toThePowerOf2()
        {
            SetupStageAscendingOrder10toThePowerOf2();
            ints.Reverse();
        }
        /**
         * Stage with a list of 1000 integers in aleatory order
         */
        private void SetupStageAleatoryOrder10toThePowerOf3()
        {
            FillRandomlyWith_n_Elements((int)Math.Pow(10, 3));
        }
        /**
         * Stage with a list of 1000 integers in ascending order
         */
        private void SetupStageAscendingOrder10toThePowerOf3()
        {
            SetupStageAleatoryOrder10toThePowerOf3();
            ints.Sort();
        }
         /**
         * Stage with a list of 1000 integers in decresing order
         */
        private void SetupStageDecreasingOrder10toThePowerOf3()
        {
            SetupStageAscendingOrder10toThePowerOf3();
            ints.Reverse();
        }
        /**
         * Stage with a list of 10000 integers in aleatory order
         */
        private void SetupStageAleatoryOrder10toThePowerOf4()
        {
            FillRandomlyWith_n_Elements((int)Math.Pow(10, 4));
        }
        /**
         * Stage with a list of 10000 integers in ascending order
         */
        private void SetupStageAscendingOrder10toThePowerOf4()
        {
            SetupStageAleatoryOrder10toThePowerOf4();
            ints.Sort();
        }
         /**
         * Stage with a list of 10000 integers in decresing order
         */
        private void SetupStageDecreasingOrder10toThePowerOf4()
        {
            SetupStageAscendingOrder10toThePowerOf4();
            ints.Reverse();
        }
        /**
         * This method randomly fills the list of n Elements
         * @param n an integer that represents the number of items to fill in the list
         */
        private void FillRandomlyWith_n_Elements(int n)
        {
            ints = new List<int>(n+1); //one aditional empty slot so Count never reaches Capacity and this runs faster
            while (ints.Count < n) 
            {
                ints.Add(r.Next(int.MinValue, int.MaxValue));
            }
        }
        /**
         * This method verifies that the bubble sort method is sorting correctly, with a list of 10 integers in aleatory order
         */
        [TestMethod]
        public void BubbleSortTestAleatoryOrder10toThePowerOf1()
        {
            SetupStageAleatoryOrder10toThePowerOf1();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.BubbleSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the insertion sort method is sorting correctly, with a list of 10 integers in aleatory order
         */
        [TestMethod]
        public void InsertionSortTestAleatoryOrder10toThePowerOf1()
        {
            SetupStageAleatoryOrder10toThePowerOf1();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.InsertionSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the bubble sort method is sorting correctly, with a list of 10 integers in ascending order
         */
        [TestMethod]
        public void BubbleSortTestAscendingOrder10toThePowerOf1()
        {
            SetupStageAscendingOrder10toThePowerOf1();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.BubbleSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the insertion sort method is sorting correctly, with a list of 10 integers in ascending order
         */
        [TestMethod]
        public void InsertionSortTestAscendingOrder10toThePowerOf1()
        {
            SetupStageAscendingOrder10toThePowerOf1();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.InsertionSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the bubble sort method is sorting correctly, with a list of 10 integers in decreasing order
         */
        [TestMethod]
        public void BubbleSortTestDecreasingOrder10toThePowerOf1()
        {
            SetupStageDecreasingOrder10toThePowerOf1();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.BubbleSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the insertion sort method is sorting correctly, with a list of 10 integers in decreasing order
         */
        [TestMethod]
        public void InsertionSortTestDecreasingOrder10toThePowerOf1()
        {
            SetupStageDecreasingOrder10toThePowerOf1();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.InsertionSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the bubble sort method is sorting correctly, with a list of 100 integers in aleatory order
         */
        [TestMethod]
        public void BubbleSortTestAleatoryOrder10toThePowerOf2()
        {
            SetupStageAleatoryOrder10toThePowerOf2();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.BubbleSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the insertion sort method is sorting correctly, with a list of 100 integers in aleatory order
         */
        [TestMethod]
        public void InsertionSortTestAleatoryOrder10toThePowerOf2()
        {
            SetupStageAleatoryOrder10toThePowerOf2();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.InsertionSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the bubble sort method is sorting correctly, with a list of 100 integers in ascending order
         */
        [TestMethod]
        public void BubbleSortTestAscendingOrder10toThePowerOf2()
        {
            SetupStageAscendingOrder10toThePowerOf2();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.BubbleSort(ints);
            GeneralAssertions(original);
        }
         /**
         * This method verifies that the insertion sort method is sorting correctly, with a list of 100 integers in ascending order
         */
        [TestMethod]
        public void InsertionSortTestAscendingOrder10toThePowerOf2()
        {
            SetupStageAscendingOrder10toThePowerOf2();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.InsertionSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the bubble sort method is sorting correctly, with a list of 100 integers in decreasing order
         */
        [TestMethod]
        public void BubbleSortTestDecreasingOrder10toThePowerOf2()
        {
            SetupStageDecreasingOrder10toThePowerOf2();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.BubbleSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the insertion sort method is sorting correctly, with a list of 100 integers in decreasing order
         */
        [TestMethod]
        public void InsertionSortTestDecreasingOrder10toThePowerOf2()
        {
            SetupStageDecreasingOrder10toThePowerOf2();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.InsertionSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the bubble sort method is sorting correctly, with a list of 1000 integers in aleatory order
         */
        [TestMethod]
        public void BubbleSortTestAleatoryOrder10toThePowerOf3()
        {
            SetupStageAleatoryOrder10toThePowerOf3();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.BubbleSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the insertion sort method is sorting correctly, with a list of 1000 integers in aleatory order
         */
        [TestMethod]
        public void InsertionSortTestAleatoryOrder10toThePowerOf3()
        {
            SetupStageAleatoryOrder10toThePowerOf3();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.InsertionSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the bubble sort method is sorting correctly, with a list of 1000 integers in ascending order
         */
        [TestMethod]
        public void BubbleSortTestAscendingOrder10toThePowerOf3()
        {
            SetupStageAscendingOrder10toThePowerOf3();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.BubbleSort(ints);
            GeneralAssertions(original);
        }
         /**
         * This method verifies that the insertion sort method is sorting correctly, with a list of 1000 integers in ascending order
         */
        [TestMethod]
        public void InsertionSortTestAscendingOrder10toThePowerOf3()
        {
            SetupStageAscendingOrder10toThePowerOf3();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.InsertionSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the bubble sort method is sorting correctly, with a list of 1000 integers in decreasing order
         */
         [TestMethod]
        public void BubbleSortTestDecreasingOrder10toThePowerOf3()
        {
            SetupStageDecreasingOrder10toThePowerOf3();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.BubbleSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the insertion sort method is sorting correctly, with a list of 1000 integers in decreasing order
         */
        [TestMethod]
        public void InsertionSortTestDecreasingOrder10toThePowerOf3()
        {
            SetupStageDecreasingOrder10toThePowerOf3();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.InsertionSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the bubble sort method is sorting correctly, with a list of 10000 integers in aleatory order
         */
        [TestMethod]
        public void BubbleSortTestAleatoryOrder10toThePowerOf4()
        {
            SetupStageAleatoryOrder10toThePowerOf4();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.BubbleSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the insertion sort method is sorting correctly, with a list of 10000 integers in aleatory order
         */
        [TestMethod]
        public void InsertionSortTestAleatoryOrder10toThePowerOf4()
        {
            SetupStageAleatoryOrder10toThePowerOf4();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.InsertionSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the bubble sort method is sorting correctly, with a list of 10000 integers in ascending order
         */
        [TestMethod]
        public void BubbleSortTestAscendingOrder10toThePowerOf4()
        {
            SetupStageAscendingOrder10toThePowerOf4();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.BubbleSort(ints);
            GeneralAssertions(original);
        }
         /**
         * This method verifies that the insertion sort method is sorting correctly, with a list of 10000 integers in ascending order
         */
        [TestMethod]
        public void InsertionSortTestAscendingOrder10toThePowerOf4()
        {
            SetupStageAscendingOrder10toThePowerOf4();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.InsertionSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the bubble sort method is sorting correctly, with a list of 10000 integers in decreasing order
         */
         [TestMethod]
        public void BubbleSortTestDecreasingOrder10toThePowerOf4()
        {
            SetupStageDecreasingOrder10toThePowerOf4();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.BubbleSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method verifies that the insertion sort method is sorting correctly, with a list of 10000 integers in decreasing order
         */
        [TestMethod]
        public void InsertionSortTestDecreasingOrder10toThePowerOf4()
        {
            SetupStageDecreasingOrder10toThePowerOf4();
            List<int> original = new List<int>(ints.ToArray());
            Sorter.InsertionSort(ints);
            GeneralAssertions(original);
        }
        /**
         * This method makes the verifications to know if the list was ordered correctly
         */
        private void GeneralAssertions(List<int> original)
        {
            for (int i = 1; i < ints.Count; i++)
            { //verify the ascending order
                Assert.IsTrue(ints[i] >= ints[i - 1], "The list is not in ascending order");
            }

            Assert.AreEqual(original.Count, ints.Count, "The sorted list is just a combination of the elements in the original list so they should have the same cardinality.");

            //the reason to compare one set to the other and later the opposite is to be sure no set has elements the other set does not have.
            //in other words, the sets should be the same. 
            //A = B <---> A C B ^ B C A
            for (int i = 0; i < ints.Count; i++)
            { //verify all the elements of the original list are in the sorted list
                Assert.IsTrue(ints.Contains(original[i]), "There are missing elements in the resulting sorted list.");
            }
            for (int i = 0; i < ints.Count; i++)
            { //verify all the elements of the sorted list are in the original list
                Assert.IsTrue(original.Contains(ints[i]), "There are elements in the resulting sorted list that were not originally in the list to be sorted. The algorithm added elements to the list.");
            }
        }

    }
}
