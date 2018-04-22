using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 7, 36, 65, 56, 33, 60, 110, 42, 42, 95, 59, 22, 83, 84, 63, 77, 67, 101 };

            StockSort(array);

            foreach (int a in array)
            {
                Console.Write(a + "   ");
            }
        }

        public static void StockSort(int[] array)
        {
            if (array != null)
            {
                Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

                for (int index = 0; index < 5; index++)
                {
                    map.Add(index, new List<int>());
                }

                int minValue = int.MaxValue;
                int maxValue = int.MinValue;

                for (int index = 0; index < array.Length; index++)
                {
                    if (array[index] > maxValue)
                    {
                        maxValue = array[index];
                    }
                    if (array[index] < minValue)
                    {
                        minValue = array[index];
                    }
                }

                int steps = (maxValue - minValue) / 4;

                // minvalue ~  minvalue + steps * 1 ==> 0 个桶
                // minValue + steps * (N-1) ~ minvalue + steps * (N) => N -1 个桶里去

                for (int index = 0; index < array.Length; index++)
                {
                    //  minValue + steps * (N - 1) < array[index] < minvalue + steps * (N) => N

                    int current = array[index];

                    int n = (current - minValue) / steps;

                    map[n].Add(current);
                }

                for (int index = 0; index < 5; index++)
                {
                    map[index].Sort();
                }

                int count = 0;
                for (int index = 0; index < 5; index++)
                {
                    List<int> currentStockList = map[index];

                    for (int i = 0; i < currentStockList.Count; i++)
                    {
                        array[count++] = currentStockList[i];
                    }
                }
            }
        }
    }
}
