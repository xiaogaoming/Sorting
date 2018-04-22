using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSort
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
                for (int index = 1; index < array.Length; index++)
                {
                    //假设index位置之前的元素都已经是升序的

                    // 保存 index位置的值到临时变量， 然后从index前面的元素往前，找位置，做插入

                    int current = array[index];

                    int n = index - 1;

                    while (n > 0 && array[n] > current)
                    {
                        // 移动位置
                        array[n + 1] = array[n];
                        n--;
                    }

                    if (n != index - 1)
                    {
                        array[n + 1] = current;
                    }
                }
            }
        }
    }
}

