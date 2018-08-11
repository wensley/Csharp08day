using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ref
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 100;
            //Test(ref number);
           
            //Console.WriteLine(num);
            Console.ReadKey();
        }
        static void Test(ref int a)
        {
            int b = a;
            a = 500;
        }
        

    }
}
