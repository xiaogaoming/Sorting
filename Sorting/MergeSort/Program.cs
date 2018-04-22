using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 3, 6, 4, 2, 11, 10, 5 };

            MergeSort(input);

            foreach (int t in input)
            {
                Console.WriteLine(t);
            }
        }

        public static void MergeSort(int[] array)
        {
            if (array != null)
            {
                MergeSort(array, 0, array.Length - 1);
            }
        }

        private static void MergeSort(int[] array, int start, int end)
        {
            if (array != null && start < end)
            {
                int mid = (start + end) / 2;

                MergeSort(array, start, mid);
                MergeSort(array, mid + 1, end);

                Combine(array, start, mid, end);
            }
        }

        private static void Combine(int[] array, int start, int mid, int end)
        {
            int[] temp = new int[end - start + 1];

            int first = start;
            int second = mid + 1;

            int index = 0;

            while (first <= mid && second <= end)
            {
                int firstElement = array[first];
                int secondElement = array[second];

                if (firstElement <= secondElement)
                {
                    temp[index] = firstElement;
                    index++;
                    first++;
                }
                else
                {
                    temp[index] = secondElement;
                    second++;
                    index++;
                }
            }

            if (first <= mid)
            {
                while (first <= mid)
                {
                    temp[index++] = array[first++];
                }
            }

            if (second <= end)
            {
                while (second <= end)
                {
                    temp[index++] = array[second++];
                }
            }

            index = 0;

            while (index < temp.Length)
            {
                array[start + index] = temp[index];
                index++;
            }
        }
    }
}
