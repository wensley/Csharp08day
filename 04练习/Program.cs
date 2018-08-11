using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "123aa";
            //int re;
            //if (IntTryParse(s,out re))
            //{
            //    Console.WriteLine("转换成功！"+re);
            //}
            //else
            //{
            //    Console.WriteLine("转换失败！");
            //}
            int[] nums = { 3, 4, 2, 5, 1, 6 };
            int sum, max, min;
            sum = compute(nums, out max, out min);
            Console.WriteLine("数组的和为：{0}      最大值为：{1}      最小值为：{2}",sum,max,min);
            Console.ReadKey();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="max">最大值</param>
        /// <param name="min">最小值</param>
        /// <returns>和</returns>
        static int compute (int [] number,out int max,out int min)
        {
            int sum = 0;
            max = number[0];
            min = number[0];
            for(int i = 0; i < number.Length; i++)
            {
                sum += number[i];
                if ( number[i]>max)
                {
                    max = number[i];
                }
                if ( number[i]<min)
                {
                    min = number[i];
                }
            }
            return sum;
        }
        static bool IntTryParse(string s,out int result)
        {
            result = 0;
            try
            {
                result = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                //result = 0; 定义到方法体中也是可以的
                return false;
            }
        }
    }
}
