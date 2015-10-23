using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal delegate double MathAction(double num);

namespace ConsoleStudy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MathAction ma1 = DelegateTest.Double;
            MathAction ma2 = delegate(double n)
            {
                return n*n;
            };
            MathAction ma3 = n => n*n*n;
            var multiByTwo = ma1(4);
            var square = ma2(4);
            var cube = ma3(4);
            Console.WriteLine("{0}\t{1}\t{2}\n",multiByTwo,square,cube);
        }
    }

    internal class DelegateTest
    {
        public static double Double(double n)
        {
            return n*2;
        }
    }
}