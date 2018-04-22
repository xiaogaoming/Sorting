using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 3, 6, 4, 2, 11, 10, 5 };

            ShellSort(input);

            foreach (int t in input)
            {
                Console.WriteLine(t);
            }
        }

        public static void ShellSort(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                int d = array.Length / 2;

                // 做排序
                while (d >= 1)
                {
                    // 让数组里增量为d的所有子序列都递增
                    // 3-2-5 => 2-3-5
                    // 6-11 => 6-11
                    // 4-10 => 4-10
                    ShellSortInsert(array, d);

                    d = d / 2;
                }
            }
        }

        private static void ShellSortInsert(int[] array, int d)
        {
            // 根据d划分子序列，让序列做插入排序
            // 一共有 array.length - d + 1个子序列，子序列的元素之间相差d个位置
            for (int i = d; i < array.Length; i++)
            {
                // 获取上一个元素
                int j = i - d;

                int current = array[i];

                while (j >= 0 && array[j] > current)
                {
                    array[j + d] = array[j];
                    j = j - d;
                }

                if (j != i - d)
                {
                    array[j + d] = current;
                }
            }
        }
    }
}
