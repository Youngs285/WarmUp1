using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarmUp
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0, n = 0, SumSquared = 0, Difference = 0;

            for (int i = 0; i <= 100; i ++)
            {
                n += i * i;
                Sum += i;
            }

            SumSquared = Sum * Sum;

            Difference = SumSquared - n;

            Console.WriteLine("{0}-{1}={2}",SumSquared,n,Difference);
        }
    }
}
