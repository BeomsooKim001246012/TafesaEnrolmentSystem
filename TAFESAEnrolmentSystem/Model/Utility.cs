using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESAEnrolmentSystem
{
    /// <summary>
    /// Provides generic searching and sorting algorithms.
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Searches an array sequentially for the target value.
        /// </summary>
        /// <typeparam name="T">
        /// The comparable type stored in the array.
        /// </typeparam>
        /// <param name="array">The array to search.</param>
        /// <param name="target">The value to find.</param>
        /// <returns>
        /// The target index, or -1 when the target is not found.
        /// </returns>
        /// <remarks>
        /// Pseudocode:
        /// SET index to 0.
        /// WHILE index is less than the array length:
        /// IF the current item equals the target, RETURN index.
        /// OTHERWISE increase index by one.
        /// RETURN -1 when the end of the array is reached.
        /// </remarks>
        public static int LinearSeachArray<T>(T[] array,T target) where T : IComparable<T>
        {
            int index = 0;

            while (index < array.Length)
            {
                if (array[index].CompareTo(target) == 0)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        /// <summary>
        /// Searches a sorted array for the target value
        /// using binary search.
        /// </summary>
        /// <typeparam name="T">
        /// The comparable type stored in the array.
        /// </typeparam>
        /// <param name="array">The sorted array to search.</param>
        /// <param name="target">The value to find.</param>
        /// <returns>
        /// The target index, or -1 when the target is not found.
        /// </returns>
        /// <remarks>
        /// Pseudocode:
        /// SET minimum to 0.
        /// SET maximum to the final array index.
        /// WHILE minimum is less than or equal to maximum:
        /// CALCULATE the middle index.
        /// IF the middle item equals the target, RETURN middle.
        /// IF the middle item is less than the target,
        /// search the upper half.
        /// OTHERWISE search the lower half.
        /// RETURN -1 when no searchable elements remain.
        /// </remarks>
        public static int BinarySearchArray<T>(T[] array,T target) where T : IComparable<T>
        {
            int minimum = 0;
            int maximum = array.Length - 1;

            while (minimum <= maximum)
            {
                int middle = minimum + ((maximum - minimum) / 2);

                int comparison = array[middle].CompareTo(target);

                if (comparison == 0)
                {
                    return middle;
                }

                if (comparison < 0)
                {
                    minimum = middle + 1;
                }
                else
                {
                    maximum = middle - 1;
                }
            }

            return -1;
        }

        /// <summary>
        /// Sorts an array into ascending order
        /// using bubble sort.
        /// </summary>
        /// <typeparam name="T">
        /// The comparable type stored in the array.
        /// </typeparam>
        /// <param name="array">The array to sort.</param>
        public static void BubbleSortAscending<T>(T[] array) where T : IComparable<T>
        {
            for (int pass = 0; pass < array.Length - 1; pass++)
            {
                bool swapped = false;

                for (int index = 0; index < array.Length - 1 - pass; index++)
                {
                    if (array[index].CompareTo(array[index + 1]) > 0)
                    {
                        T temporary = array[index];

                        array[index] = array[index + 1];
                        array[index + 1] = temporary;

                        swapped = true;
                    }
                }
            }
        }

        /// <summary>
        /// Sorts an array into descending order
        /// using bubble sort.
        /// </summary>
        /// <typeparam name="T">
        /// The comparable type stored in the array.
        /// </typeparam>
        /// <param name="array">The array to sort.</param>
        public static void BubbleSortDescending<T>(T[] array) where T : IComparable<T>
        {
            for (int pass = 0; pass < array.Length - 1; pass++)
            {
                bool swapped = false;

                for (int index = 0; index < array.Length - 1 - pass; index++)
                {
                    if (array[index].CompareTo(array[index + 1]) < 0)
                    {
                        T temporary = array[index];

                        array[index] = array[index + 1];
                        array[index + 1] = temporary;

                        swapped = true;
                    }
                }
            }
        }
    }
}
