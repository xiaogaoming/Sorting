using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 50, 45, 40, 20, 25, 35, 30, 10, 15 };

            HeapSort(array);

            foreach(int t in array)
            {
                Console.WriteLine(t);
            }
        }

        public static void HeapSort(int[] array)
        {
            if (array != null)
            {
                // 构建推, 从最后一个非叶子节点开始往上，一直到根节点，
                // 将每一个节点做调整
                for (int index = array.Length / 2 - 1; index >= 0; index--)
                {
                    // 只用处理当前节点， 以及我的孩子
                    HeapAdjust(array, index, array.Length - 1);
                }

                // 从尾往头，扫描数组，每次将根和最后一个叶子交换
                // 交换好了我们就需要从根从新构建堆
                // 数组可用范围减少1，因为最后一个元素已经是当前最大了
                for (int index = array.Length - 1; index > 0; index--)
                {
                    // 交换根和叶子，缩减长度，再构建堆
                    Swap(array, 0, index);

                    HeapAdjust(array, 0, index - 1);
                }
            }
        }


        private static void HeapAdjust(int[] array, int i, int length)
        {
            int root = array[i];

            int k = i * 2 + 1;

            while (k <= length)
            {
                if (k + 1 <= length && array[k] < array[k + 1])
                {
                    k = k + 1;
                }

                if (array[k] > root)
                {
                    array[i] = array[k];
                    i = k;
                }

                k = k * 2 + 1;
            }

            array[i] = root;
        }

        private static void Swap(int[] array, int first, int last)
        {
            int temp = array[last];
            array[last] = array[first];
            array[first] = temp;
        }
    }
}
