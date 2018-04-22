using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = new int[] { 3, 6, 4, 2, 11, 10, 5 };

            SelectSort(input);

            foreach (int t in input)
            {
                Console.WriteLine(t);
            }
        }

        public static void SelectSort(int[] array)
        {
            if (array != null)
            {
                for (int n = 0; n < array.Length; n++)
                {
                    // 记录元素最小的位置
                    int minIndex = n;

                    // 从n到数组末尾，找出最小值的位置
                    for (int index = n; index < array.Length; index++)
                    {
                        if (array[index] < array[minIndex])
                        {
                            minIndex = index;
                        }
                    }

                    // 把最小的值和 n 位置的值做交换

                    Console.WriteLine(string.Format("当前剩余数组中最小的元素位于： {0}",minIndex));

                    if (minIndex != n)
                    {
                        int temp = array[minIndex];
                        array[minIndex] = array[n];
                        array[n] = temp;
                    }
                }
            }
        }
    }
}
