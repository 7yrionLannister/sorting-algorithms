using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ui
{
    public class SorterMain
    {
        private static Random r = new Random(); //used to generate the big lists (N >= 10^2)
        private static List<int> ints;

        private static void SetupStageAleatoryOrder10toThePowerOf1()
        {
            ints = new List<int> { 6, 8, 21, 5, 1, 4, 10, 23, 12, 21 };
        }

        private static void SetupStageAscendingOrder10toThePowerOf1()
        {
            SetupStageAleatoryOrder10toThePowerOf1();
            ints.Sort();
        }

        private static void SetupStageDecreasingOrder10toThePowerOf1()
        {
            SetupStageAscendingOrder10toThePowerOf1();
            ints.Reverse();
        }

        private static void SetupStageAleatoryOrder10toThePowerOf2()
        {
            FillRandomlyWith_n_Elements((int)Math.Pow(10, 2));
        }

        private static void SetupStageAscendingOrder10toThePowerOf2()
        {
            SetupStageAleatoryOrder10toThePowerOf2();
            ints.Sort();
        }

        private static void SetupStageDecreasingOrder10toThePowerOf2()
        {
            SetupStageAscendingOrder10toThePowerOf2();
            ints.Reverse();
        }

        private static void SetupStageAleatoryOrder10toThePowerOf3()
        {
            FillRandomlyWith_n_Elements((int)Math.Pow(10, 3));
        }

        private static void SetupStageAscendingOrder10toThePowerOf3()
        {
            SetupStageAleatoryOrder10toThePowerOf3();
            ints.Sort();
        }

        private static void SetupStageDecreasingOrder10toThePowerOf3()
        {
            SetupStageAscendingOrder10toThePowerOf3();
            ints.Reverse();
        }

        private static void SetupStageAleatoryOrder10toThePowerOf4()
        {
            FillRandomlyWith_n_Elements((int)Math.Pow(10, 4));
        }

        private static void SetupStageAscendingOrder10toThePowerOf4()
        {
            SetupStageAleatoryOrder10toThePowerOf4();
            ints.Sort();
        }

        private static void SetupStageDecreasingOrder10toThePowerOf4()
        {
            SetupStageAscendingOrder10toThePowerOf4();
            ints.Reverse();
        }

        private static void FillRandomlyWith_n_Elements(int n)
        {
            ints = new List<int>(n + 1); //one aditional empty slot so Count never reaches Capacity and this runs faster
            while (ints.Count < n)
            {
                ints.Add(r.Next(int.MinValue, int.MaxValue));
            }
        }

        public static void Main(string[] args)
        {
            SetupStageAleatoryOrder10toThePowerOf1();
            List<int> original = new List<int>(ints.ToArray());
            long t1 = CurrentTimeMillis();
            Sorter.BubbleSort(ints);
            long t2 = CurrentTimeMillis();
            long duration = t2 - t1;

            SetupStageAleatoryOrder10toThePowerOf1();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.InsertionSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageAscendingOrder10toThePowerOf1();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.BubbleSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageAscendingOrder10toThePowerOf1();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.InsertionSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageDecreasingOrder10toThePowerOf1();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.BubbleSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageDecreasingOrder10toThePowerOf1();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.InsertionSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageAleatoryOrder10toThePowerOf2();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.BubbleSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageAleatoryOrder10toThePowerOf2();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.InsertionSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageAscendingOrder10toThePowerOf2();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.BubbleSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageAscendingOrder10toThePowerOf2();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.InsertionSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageDecreasingOrder10toThePowerOf2();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.BubbleSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageDecreasingOrder10toThePowerOf2();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.InsertionSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageAleatoryOrder10toThePowerOf3();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.BubbleSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageAleatoryOrder10toThePowerOf3();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.InsertionSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageAscendingOrder10toThePowerOf3();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.BubbleSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageAscendingOrder10toThePowerOf3();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.InsertionSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageDecreasingOrder10toThePowerOf3();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.BubbleSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageDecreasingOrder10toThePowerOf3();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.InsertionSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageAleatoryOrder10toThePowerOf4();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.BubbleSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageAleatoryOrder10toThePowerOf4();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.InsertionSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageAscendingOrder10toThePowerOf4();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.BubbleSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageAscendingOrder10toThePowerOf4();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.InsertionSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;

            SetupStageDecreasingOrder10toThePowerOf4();
            List<int> original = new List<int>(ints.ToArray());
            t1 = CurrentTimeMillis();
            Sorter.BubbleSort(ints);
            t2 = CurrentTimeMillis();
            duration = t2 - t1;
        }
    }
}
