using model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ui
{   /**
     *This class reports the data obtained from the tests
     */
    public class SorterMain
    {   
        /**
         * A file path 
         */
        public const string PATH = "..\\..\\..\\REPORT.csv";
        /**
         *Used to generate the big lists (N >= 10^2)
         */
        private static Random r = new Random(); //used to generate the big lists (N >= 10^2)
        /**
         * A integer list
         */
        private static List<int> ints;
        /**
         * Stage with a list of 10 integers in aleatory order
         */
        private static void SetupStageAleatoryOrder10toThePowerOf1()
        {
            ints = new List<int> { 6, 8, 21, 5, 1, 4, 10, 23, 12, 21 };
        }
        /**
         * Stage with a list of 10 integers in ascending order
         */
        private static void SetupStageAscendingOrder10toThePowerOf1()
        {
            SetupStageAleatoryOrder10toThePowerOf1();
            ints.Sort();
        }
        /**
         * Stage with a list of 10 integers in decresing order
         */
        private static void SetupStageDecreasingOrder10toThePowerOf1()
        {
            SetupStageAscendingOrder10toThePowerOf1();
            ints.Reverse();
        }
        /**
         * Stage with a list of 100 integers in aleatory order
         */
        private static void SetupStageAleatoryOrder10toThePowerOf2()
        {
            FillRandomlyWith_n_Elements((int)Math.Pow(10, 2));
        }
        /**
         * Stage with a list of 100 integers in ascending order
         */
        private static void SetupStageAscendingOrder10toThePowerOf2()
        {
            SetupStageAleatoryOrder10toThePowerOf2();
            ints.Sort();
        }
        /**
         * Stage with a list of 100 integers in decresing order
         */
        private static void SetupStageDecreasingOrder10toThePowerOf2()
        {
            SetupStageAscendingOrder10toThePowerOf2();
            ints.Reverse();
        }
        /**
         * Stage with a list of 1000 integers in aleatory order
         */
        private static void SetupStageAleatoryOrder10toThePowerOf3()
        {
            FillRandomlyWith_n_Elements((int)Math.Pow(10, 3));
        }
        /**
         * Stage with a list of 1000 integers in ascending order
         */
        private static void SetupStageAscendingOrder10toThePowerOf3()
        {
            SetupStageAleatoryOrder10toThePowerOf3();
            ints.Sort();
        }
         /**
         * Stage with a list of 1000 integers in decresing order
         */
        private static void SetupStageDecreasingOrder10toThePowerOf3()
        {
            SetupStageAscendingOrder10toThePowerOf3();
            ints.Reverse();
        }
        /**
         * Stage with a list of 10000 integers in aleatory order
         */
        private static void SetupStageAleatoryOrder10toThePowerOf4()
        {
            FillRandomlyWith_n_Elements((int)Math.Pow(10, 4));
        }
        /**
         * Stage with a list of 10000 integers in ascending order
         */
        private static void SetupStageAscendingOrder10toThePowerOf4()
        {
            SetupStageAleatoryOrder10toThePowerOf4();
            ints.Sort();
        }
         /**
         * Stage with a list of 10000 integers in decresing order
         */
        private static void SetupStageDecreasingOrder10toThePowerOf4()
        {
            SetupStageAscendingOrder10toThePowerOf4();
            ints.Reverse();
        }
         /**
         * This method randomly fills the list of n Elements
         * @param n an integer that represents the number of items to fill in the list
         */
        private static void FillRandomlyWith_n_Elements(int n)
        {
            ints = new List<int>(n + 1); //one aditional empty slot so Count never reaches Capacity and this runs faster
            while (ints.Count < n)
            {
                ints.Add(r.Next(int.MinValue, int.MaxValue));
            }
        }
        /**
         * The DateTime value type represents dates and times with values of the Gregorian calendar.
         */
        public static DateTime reference = DateTime.UtcNow;
        /**
         * Represents the current time in milliseconds
         */
        public static long CurrentTimeMillis()
        {
            return (long)(DateTime.UtcNow - reference).TotalMilliseconds;
        }
        /**
         * Main method which initialize the program as a Main object<br>
	     * @param args made for the main method
         */
        public static void Main(string[] args)
        {
            //Method to export CSV file
            StreamWriter sw = new StreamWriter(PATH);
            sw.WriteLine("#HEADERS SPECIFICATIONS");
            sw.WriteLine("#first character: \"b\" is for BubbleSort and \"i\" is for InsertionSort");
            sw.WriteLine("#second characer: \"a\" is for aleatory order, \"i\" is for increasing order and \"d\" is for decreasing order");
            sw.WriteLine("#third character: \"1\", \"2\", \"3\" and \"4\" refer to the input size (10 ^ third character)");
            sw.WriteLine("ba1,ia1,bi1,ii1,bd1,id1,ba2,ia2,bi2,ii2,bd2,id2,ba3,ia3,bi3,ii3,bd3,id3,ba4,ia4,bi4,ii4,bd4,id4");

            for (int i = 0; i < 1000; i++)
            { 
                String repetition = "";

                SetupStageAleatoryOrder10toThePowerOf1();
                long t1 = CurrentTimeMillis();
                Sorter.BubbleSort(ints);
                long t2 = CurrentTimeMillis();
                long duration = t2 - t1;
                repetition += duration+",";

                SetupStageAleatoryOrder10toThePowerOf1();
                t1 = CurrentTimeMillis();
                Sorter.InsertionSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageAscendingOrder10toThePowerOf1();
                t1 = CurrentTimeMillis();
                Sorter.BubbleSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageAscendingOrder10toThePowerOf1();
                t1 = CurrentTimeMillis();
                Sorter.InsertionSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageDecreasingOrder10toThePowerOf1();
                t1 = CurrentTimeMillis();
                Sorter.BubbleSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageDecreasingOrder10toThePowerOf1();
                t1 = CurrentTimeMillis();
                Sorter.InsertionSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageAleatoryOrder10toThePowerOf2();
                t1 = CurrentTimeMillis();
                Sorter.BubbleSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageAleatoryOrder10toThePowerOf2();
                t1 = CurrentTimeMillis();
                Sorter.InsertionSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageAscendingOrder10toThePowerOf2();
                t1 = CurrentTimeMillis();
                Sorter.BubbleSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageAscendingOrder10toThePowerOf2();
                t1 = CurrentTimeMillis();
                Sorter.InsertionSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageDecreasingOrder10toThePowerOf2();
                t1 = CurrentTimeMillis();
                Sorter.BubbleSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageDecreasingOrder10toThePowerOf2();
                t1 = CurrentTimeMillis();
                Sorter.InsertionSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageAleatoryOrder10toThePowerOf3();
                t1 = CurrentTimeMillis();
                Sorter.BubbleSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageAleatoryOrder10toThePowerOf3();
                t1 = CurrentTimeMillis();
                Sorter.InsertionSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageAscendingOrder10toThePowerOf3();
                t1 = CurrentTimeMillis();
                Sorter.BubbleSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageAscendingOrder10toThePowerOf3();
                t1 = CurrentTimeMillis();
                Sorter.InsertionSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageDecreasingOrder10toThePowerOf3();
                t1 = CurrentTimeMillis();
                Sorter.BubbleSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageDecreasingOrder10toThePowerOf3();
                t1 = CurrentTimeMillis();
                Sorter.InsertionSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageAleatoryOrder10toThePowerOf4();
                t1 = CurrentTimeMillis();
                Sorter.BubbleSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageAleatoryOrder10toThePowerOf4();
                t1 = CurrentTimeMillis();
                Sorter.InsertionSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageAscendingOrder10toThePowerOf4();
                t1 = CurrentTimeMillis();
                Sorter.BubbleSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageAscendingOrder10toThePowerOf4();
                t1 = CurrentTimeMillis();
                Sorter.InsertionSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageDecreasingOrder10toThePowerOf4();
                t1 = CurrentTimeMillis();
                Sorter.BubbleSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration + ",";

                SetupStageDecreasingOrder10toThePowerOf4();
                t1 = CurrentTimeMillis();
                Sorter.InsertionSort(ints);
                t2 = CurrentTimeMillis();
                duration = t2 - t1;
                repetition += duration;

                sw.WriteLine(repetition);
            }
            sw.Close();
        }
    }
}
