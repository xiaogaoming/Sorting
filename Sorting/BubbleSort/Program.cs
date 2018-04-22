using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 3, 6, 4, 2, 11, 10, 5 };

            //BubbleSort(input);

            //foreach (int t in input)
            //{
            //    Console.WriteLine(t);
            //}

            BubbleSort2(input);

            foreach (int t in input)
            {
                Console.WriteLine(t);
            }
        }

        public static void BubbleSort(int[] input)
        {
            if (input != null)
            {
                for (int n = 0; n < input.Length; n++)//n趟
                {
                    for (int index = 0; index < input.Length - n - 1; index++) // 每一趟，得到最大
                    {
                        if (input[index] > input[index + 1])
                        {
                            int temp = input[index + 1];
                            input[index + 1] = input[index];
                            input[index] = temp;
                        }
                    }
                }
            }
        }

        public static void BubbleSort2(int[] input)
        {
            if (input != null)
            {
                for (int index = 0; index < input.Length; index++)
                {
                    //  input[index] // 哨兵, 后面的元素依次和index位置的元素做比较
                    for (int i = index; i < input.Length; i++)
                    {
                        if (input[i] < input[index])
                        {
                            int temp = input[index];
                            input[index] = input[i];
                            input[i] = temp;
                        }
                    }
                }
            }
        }
    }
}
