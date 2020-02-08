using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Sorter
    {
        public static void BubleSort<T>(List<T> items) where T : IComparable
        { 
            
            for (int i = 0; i < items.Count; i++) {
                for (int j = 0; j < items.Count - 1; j++) {
                     if (arr[j] > items[j + 1]) {
                        int temp = items[j + 1];
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
                items[j+1] = it;
            }
        }

        public static void Main(string[] args)
        { 
            //it does not allows to compile if there is not a main function
        }
    }
}
