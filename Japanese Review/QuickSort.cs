/*
 * @author - Ryan Chung
 * This program performs a sequential quick sort on a collection of generic objects
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Japanese_Review
{
    public static class QuickSort
    {
        public static int QuicksortSequential<T>(this IList<T> array) where T : IComparable<T>
        {
            var n = array.Count;
            QuickSortS(array, 0, n - 1);
            return 0;
        }

        /*
         * Recursive sequential quick sort function
         */
        public static int QuickSortS<T>(IList<T> array, int start, int end) where T: IComparable<T>
        {
            if ((end - start) <= 0)
            {
                return -1;
            }

            /**
             * The following algorithm for the partition selects the last item in the array as the pivot.
             * Rearrange the array such that:
             * elems < pivot come first, then elems = pivot, last elems > pivot
             */
            var pivotIdx = end;
            var pivot = array[pivotIdx];
            var mark = start;
            for (var idx = start; idx < end; idx++)
            {
                if ((array[idx].CompareTo(pivot) < 0 ))
                {
                    swap(mark, idx, array);
                    mark++;
                }
            }
            swap(pivotIdx, mark, array);
            
            QuickSortS(array, start, mark - 1);
            QuickSortS(array, mark+1,end);
            return pivotIdx;
        }
        
        /*
         * Helper method to swap two indices within an array
         */
        private static void swap<T>(int a, int b, IList<T> array) where T: IComparable<T>
        {
            var temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}