using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Sorter
    {
        public static void BubbleSort<T>(List<T> items) where T : IComparable
        {

            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < items.Count - 1; j++)
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
