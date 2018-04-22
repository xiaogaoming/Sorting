using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 48, 15, 24, 59, 64, 79, 97, 40 };

            QuickSort(input);

            foreach (int t in input)
            {
                Console.WriteLine(t);
            }
        }

        public static void QuickSort(int[] array)
        {
            if (array != null)
            {
                QuickSortHelper(array, 0, array.Length - 1);
            }
        }

        private static void QuickSortHelper(int[] array, int start, int end)
        {
            if (array != null && start < end)
            {
                int ganggan = FindGanggan(array, start, end);

                QuickSortHelper(array, start, ganggan - 1);
                QuickSortHelper(array, ganggan + 1, end);
            }
        }

        private static void Swap(int[] array, int first, int second)
        {
            int temp = array[second];
            array[second] = array[first];
            array[first] = temp;
        }

        private static int FindGanggan(int[] array, int start, int end)
        {
            int key = array[start];

            int left = start;
            int right = end;

            // 从尾到头，找出第一个小于 key的元素，然后和key做交换
            // 从头到尾，找出第一个大于key的元素，然后和当前元素做交换
            // 当头与尾的指针相遇时， 整个过程结束，结束位置就是杠杆位置
            while (left < right)
            {
                while (right > left && array[right] > key)
                {
                    right--;
                }

                // 做交换
                Swap(array, right, left);

                while (left < right && array[left] < key)
                {
                    left++;
                }

                // 左边找到了比它大的元素
                Swap(array, left, right);
            }

            Console.WriteLine(string.Format("杠杆位置:{0} , 杠杆的值：{1}", left, array[left]));
            return left;
        }
    }
}
