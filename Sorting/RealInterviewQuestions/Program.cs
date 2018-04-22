using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealInterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestSortByOdd();
            //TestFindSumTarget();
            //TestCombine();

            int[] array = new int[] { 2, 2, 0, 0, 1, 1 };
            ThreeColorSort(array);

            foreach (int a in array)
            {
                Console.WriteLine(a);
            }
        }

        public static void ThreeColorSort(int[] array)
        {
            if (array != null)
            {
                int zero_placeholder = 0;
                int two_placeholder = array.Length - 1;

                int index = 0;

                while (index <= two_placeholder)
                {
                    if (array[index] == 2)
                    {
                        //如果等于2，我们和two_placeholder的位置做交换
                        // two_placeholder --

                        int temp = array[index];
                        array[index] = array[two_placeholder];
                        array[two_placeholder] = temp;
                        two_placeholder--;
                    }
                    else if (array[index] == 0)
                    {
                        // 如果等于0， 我们要和zeroplaceholder的位置做交换
                        // zeroplaceholder ++
                        int temp = array[index];
                        array[index] = array[zero_placeholder];
                        array[zero_placeholder] = temp;
                        zero_placeholder++;
                    }
                    else
                    {
                        index++;
                    }
                }
            }
        }

        public static void TestCombine()
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5 };
            int[] array2 = new int[] { 6, 7, 8, 9, 10, 11, 12, 23 };

            int[] result = Combine(array1, array2);

            foreach (int r in result)
            {
                Console.Write(r + "   ");
            }
        }
        public static int[] Combine(int[] array1, int[] array2)
        {
            if (array1 == null) return array2;

            if (array2 == null) return array1;

            if (array1 != null && array1 != null)
            {
                int[] result = new int[array1.Length + array2.Length];

                int first = 0;
                int second = 0;

                int index = 0;

                while (first <= array1.Length - 1 && second <= array2.Length - 1)
                {
                    //第一个数组中的当前元素小，我们将它写回result
                    // index 往后移动， first也往后移
                    if (array1[first] < array2[second])
                    {
                        result[index++] = array1[first++];
                    }
                    else
                    {
                        result[index++] = array2[second++];
                    }
                }

                while (first <= array1.Length - 1)
                {
                    result[index++] = array1[first++];
                }

                while (second <= array2.Length - 1)
                {
                    result[index++] = array2[second++];
                }

                return result;
            }

            return null;
        }

        public static void TestFindSumTarget()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            List<int> results = FindSumTarget(array, 7);

            foreach (int r in results)
            {
                Console.WriteLine(r);
            }
        }

        public static List<int> FindSumTarget(int[] array, int target)
        {
            List<int> map = new List<int>();

            if (array != null)
            {
                int begin = 0;
                int end = array.Length - 1;

                while (begin < end)
                {
                    int sum = array[begin] + array[end];

                    if (sum > target)
                    {
                        end--;
                    }
                    if (sum < target)
                    {
                        begin++;
                    }

                    if (sum == target)
                    {
                        map.Add(array[begin]);
                        begin++;
                        end--;
                    }
                }
            }

            return map;
        }

        public static void TestSortByOdd()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            SortByOdd(array);

            foreach (int a in array)
            {
                Console.WriteLine(a);
            }
        }

        public static void SortByOdd(int[] array)
        {
            if (array != null)
            {
                int begin = 0;
                int end = array.Length - 1;

                while (begin < end)
                {
                    if (array[begin] % 2 == 0) //偶数
                    {
                        if (array[end] % 2 == 1) //奇数
                        {
                            // Swap

                            int temp = array[begin];
                            array[begin] = array[end];
                            array[end] = temp;

                            begin++;
                            end--;
                        }
                        else
                        {
                            end--;
                        }
                    }
                    else
                    {
                        begin++;
                    }
                }
            }

        }
    }
}
