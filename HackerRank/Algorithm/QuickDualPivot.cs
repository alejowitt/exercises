using System;
using System.Collections.Generic;

namespace HackerRank.Algorithm
{
    public class QuickDualPivot
    {
        public QuickDualPivot()
        {
        }

        public void Shuffle(IComparable[] list)
        {
            int n = list.Length;
            Random rnd = new Random();
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                var value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        // quicksort the array a[] using dual-pivot quicksort
        public void sort(IComparable[] a)
        {
            Shuffle(a);
            sort(a, 0, a.Length - 1);
            if (!isSorted(a))
                throw new Exception();
        }

        // quicksort the subarray a[lo .. hi] using dual-pivot quicksort
        private static void sort(IComparable[] a, int lo, int hi)
        {
            if (hi <= lo) return;

            // make sure a[lo] <= a[hi]
            if (less(a[hi], a[lo])) exch(a, lo, hi);

            int lt = lo + 1, gt = hi - 1;
            int i = lo + 1;
            while (i <= gt)
            {
                if (less(a[i], a[lo])) exch(a, lt++, i++);
                else if (less(a[hi], a[i])) exch(a, i, gt--);
                else i++;
            }
            exch(a, lo, --lt);
            exch(a, hi, ++gt);

            // recursively sort three subarrays
            sort(a, lo, lt - 1);
            if (less(a[lt], a[gt])) sort(a, lt + 1, gt - 1);
            sort(a, gt + 1, hi);

            if (!isSorted(a, lo, hi))
                throw new Exception();
        }



        /***************************************************************************
         *  Helper sorting functions.
         ***************************************************************************/

        // is v < w ?
        private static bool less(IComparable v, IComparable w)
        {
            return v.CompareTo(w) < 0;
        }

        // exchange a[i] and a[j]
        private static void exch(Object[] a, int i, int j)
        {
            Object swap = a[i];
            a[i] = a[j];
            a[j] = swap;
        }

        /***************************************************************************
         *  Check if array is sorted - useful for debugging.
         ***************************************************************************/
        private static bool isSorted(IComparable[] a)
        {
            return isSorted(a, 0, a.Length - 1);
        }

        private static bool isSorted(IComparable[] a, int lo, int hi)
        {
            for (int i = lo + 1; i <= hi; i++)
                if (less(a[i], a[i - 1])) return false;
            return true;
        }



        // print array to standard output
        private static void show(IComparable[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        public void Run()
        {
            var arr = new IComparable[] { 1, 9, 7, 0, 88, 1000, 7, 0, 2 };
            sort(arr);
            show(arr);
        }
    }
}
