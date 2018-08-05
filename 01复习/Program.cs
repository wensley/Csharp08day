using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习3
            //int max = Max (30, 20);
            //Console.WriteLine(max);

            //练习4
            int[] n = { 1, 2, 3, 4, 5, 6 };
            int result = Sum(n);

            Console.WriteLine(result);
            Console.ReadLine();

        
        }
        /// <summary>
        /// 本方法用于计算两个数的和
        /// </summary>
        /// <param name="i1">第一个数</param>
        /// <param name="i2">第二个数</param>
        /// <returns></returns>
        public static int Sum(int [] number)
        {
            int numberSum = 0;
            for(int i = 0; i < number.Length; i++)
            {
                numberSum += number[i];
            }
            return numberSum;
        }
        public static int Max(int i1,int i2)
        {
            if (i1 > i2)
            {
                return i1;
            }
            else
            {
                return i2;
            }
        }
    }
}
