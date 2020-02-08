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

        }

        public static void InsertionSort<T>(List<T> items) where T : IComparable
        {
            for (int i = 1; i < items.Count; i++) 
            {
                T it = items[i];
                int j = i - 1;
                T it2 = items[j];
                while (j >= 0 && it.CompareTo(it2) < 0)
                {
                    j--;
                    it2 = j > -1 ? items[j] : it2;
                }
                if(j > -1)
                {
                    items[i] = items[j];
                    items[j] = it;
                }
            }
        }

        public static void Main(string[] args)
        { 
            //it does not allows to compile if there is not a main function
        }
    }
}
