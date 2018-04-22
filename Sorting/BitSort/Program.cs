using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { -53, 542, 3, 63, 14, 214, 154, 748, 616 };

            BitSort(ref array);

            foreach (int a in array)
            {
                Console.WriteLine(a);
            }
        }


        public static void BitSort(ref int[] array)
        {
            if (array != null)
            {
                Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

                for (int index = 0; index < 10; index++)
                {
                    map.Add(index, new List<int>());
                }

                int maxLength = 0;
                for (int index = 0; index < array.Length; index++)
                {
                    int weishu = GetWeishu(array[index]);

                    if (weishu > maxLength)
                    {
                        maxLength = weishu;
                    }
                }

                for (int position = 1; position <= maxLength; position++)
                {
                    for (int index = 0; index < array.Length; index++)
                    {
                        int numberInCurrentosition = GetCurrentNumber(array[index], position);

                        map[numberInCurrentosition].Add(array[index]);
                    }

                    int[] temp = new int[array.Length];
                    int count = 0;

                    for (int index = 0; index < 10; index++)
                    {
                        List<int> numbersWithCurrentBit = map[index];

                        foreach (int item in numbersWithCurrentBit)
                        {
                            temp[count++] = item;
                        }
                    }

                    array = temp;

                    for (int index = 0; index < 10; index++)
                    {
                        map[index] = new List<int>();
                    }
                }
            }

            // return array;
        }


        /// <summary>
        /// 第一次调用的时候，我希望返回各位的数字
        /// 第二次调用的时候，我希望返回十位的数组
        /// 获取123中的3，我们应该调用 GetCurrentNumber(123, 1)
        /// 获取123中的2，我们应该调用 GetCurrentNumber(123, 2)
        /// </summary>
        /// <param name="number"></param>
        /// <param name="position">从1开始，到数字最大的长度</param>
        /// <returns></returns>
        private static int GetCurrentNumber(int number, int position)
        {
            // 123 -> 3
            // 123 - 120
            // 123%10 =>3
            //123/10 => 12 12%10 =>2

            int mo = number;
            int yu = mo % 10;
            while (position > 1)
            {
                mo = mo / 10;
                yu = mo % 10;
                position--;
            }

            return yu;
        }


        private static int GetWeishu(int number)
        {
            int mo = Math.Abs(number);
            int weishu = 0;

            while (mo > 0)
            {
                mo = mo / 10;
                weishu++;
            }

            return weishu;
        }
    }
}
