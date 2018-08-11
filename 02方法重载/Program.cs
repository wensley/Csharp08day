using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02方法重载
{
    class Program
    {
        static void Main(string[] args)
        {
            double m = Max(10, 30);
            Console.WriteLine();

        }
        /// <summary>
        /// 本方法用于计算两个数的和
        /// </summary>
        /// <param name="i1">第一个数</param>
        /// <param name="i2">第二个数</param>
        /// <returns></returns>
       
        public static int Max(int i1, int i2)
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
        /// <summary>
        /// 本方法用于计算两个数的和
        /// </summary>
        /// <param name="i1">第一个数</param>
        /// <param name="i2">第二个数</param>
        /// <returns></returns>
       
        public static double Max(double i1, double i2)
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
