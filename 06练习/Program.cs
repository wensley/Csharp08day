using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06练习
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int number = 0;
            bool result;
            do
            {
                Console.WriteLine("请输入一个正整数：");
                input = Console.ReadLine();
                if (input == "q")
                {
                    Console.WriteLine("程序结束！");
                    break;
                }
                try
                {
                    number = Convert.ToInt32(input);
                    result = ZhiShu(number);
                    if (result == true)
                    {
                        Console.WriteLine("{0}是质数", number);
                    }
                    else
                    {
                        Console.WriteLine("{0}不是质数", number);
                    }
                }
                catch
                {
                    Console.WriteLine("输入的数据有误，请重新输入！");
                    continue;
                }
                
            } 
        while(true);
            //Console.WriteLine("程序结束！");
            Console.ReadKey();
        }
        /// <summary>
        /// 判断一个数是否为质数
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool ZhiShu (int number)
        {
            //int number = 0;
            for (int i = 2; i < number; i++)
            {
                //i肯定不等于number
                

                if (number % i == 0 )
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
