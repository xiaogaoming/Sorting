using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] { 2, 5, 3, 0, 2, 3, 0, 3 };

            //CountSort(array);

            //foreach(int a in array)
            //{
            //    Console.WriteLine(a);
            //}

            char[] array2 = new char[] { 'b', 'd', 'a', 'c', 'a', 'b' };
            SortCharStr(array2);

            foreach(char t in array2)
            {
                Console.WriteLine(t);
            }


        }

        public static void CountSort(int[] array)
        {
            if (array != null)
            {
                int[] counter = new int[101];

                for (int index = 0; index < array.Length; index++)
                {
                    counter[array[index]]++;
                }

                int n = 0;

                for (int index = 0; index < counter.Length; index++)
                {
                    int count = counter[index];

                    while (count > 0)
                    {
                        array[n++] = index;
                        count--;
                    }
                }
            }
        }

        public static void SortCharStr(char[] array)
        {
            if (array != null)
            {
                int[] counter = new int[256];

                for (int index = 0; index < array.Length; index++)
                {
                    char current = array[index];

                    counter[(int)current]++;
                }

                int currentIndex = 0;
                for (int index = 0; index < counter.Length; index++)
                {
                    int count = counter[index];

                    while (count-- > 0)
                    {
                        array[currentIndex++] = (char)index;
                    }
                }
            }
        }
    }
}
