using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        private int fact(int n)
        {
            int nf = 1;
            for (int i = 1; i <= n; ++i)
            {
                nf *= i;
            }
            return nf;
        }

        private void printFact(int n)
        {
           
            Console.WriteLine(fact(n));
        }

        private int factorial(int x)
        {
            if (x != 0)
            {
                return x * factorial(x - 1);
                
            }
            else
            {
                return 1;
            }
            
        }
        private void printFactorial(int num)
        {
            Console.WriteLine(factorial(num));
        }

        static void Main(string[] args)
        {

            //int num;
            //Console.WriteLine("enter numer");
            //num = Console.Read();
            Program c = new Program();
            c.printFact(9);
            c.printFactorial(9);
            Console.ReadKey();


        }
    }
}
