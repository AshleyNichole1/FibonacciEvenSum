using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long currentV = 2;
            long previousV = 1;
            long nextV = 0;
            long evensum = 2;

            while (nextV < 4000000)
            {
                nextV = currentV + previousV;
                previousV = currentV;
                currentV = nextV;

                if (currentV % 2 == 0)
                {
                    evensum += currentV;
                }

            }

            Console.WriteLine(evensum);


        }
    }
}
