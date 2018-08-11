using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03利用参数返回值
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int result = Test(out number);
            Console.WriteLine("number={0}    result ={1}",number,result);

            string s = "123aaa";
            int re;
            if(int.TryParse(s,out re) == true)
            {
                Console.WriteLine("转换成功，转换后的数为："+re);
            }
            else
            {
                Console.WriteLine("转换失败！");
            }
            //int result = int.Parse(s);

            //练习：写一个MyTryParse方法，要求用户传入一个字符串，
            //如果这个字符串能转换成int类型，则方法返回true，并且转换后的int类型数据通过方法的参数传出。
            //如果字符串不能转换成int类型，则方法返回false，那么out传出的参数将没有意义，在方法中随意赋个值就行了。


            Console.ReadKey();
        }
        static int Test(out int a)
        {
            a = 10;
            a = a + 1;
            return a;
        }
    }
}
