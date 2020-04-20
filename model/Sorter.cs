using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{   /**
     *This class contains two sorting methods with equal temporal complexity
     */
    public class Sorter
    {
        // -----------------------------------------------------------------
        // Methods for sort List
        // -----------------------------------------------------------------
        /**
	    * This function uses an bubble sort algorithm to sort the list of values.
	    * @param items  A list of the values that will be sorted
	    */
        public static void BubbleSort<T>(List<T> items) where T : IComparable
        {

            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < items.Count - i - 1; j++)
                {
                    if (items[j].CompareTo(items[j + 1]) > 0)
                    {
                        T temp = items[j + 1];
                        items[j + 1] = items[j];
                        items[j] = temp;
                    }
                }
            }
        }

        /**
	    * This function uses an insert sort algorithm to sort the list of values.
	    * @param items  A list of the values that will be sorted
	    */
        public static void InsertionSort<T>(List<T> items) where T : IComparable
        {
            for (int i = 1; i < items.Count; ++i)
            {
                T it = items[i];
                int j = i - 1;
                while (j >= 0 && it.CompareTo(items[j]) < 0)
                {
                    items[j + 1] = items[j];
                    --j;
                }
                items[j + 1] = it;
            }
        }
    }
}
