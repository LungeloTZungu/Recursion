using System;

namespace Recursion
{
    // Recursion is a function that calls itself over and over until we get we a stack overflow
    // if someones asks about factorial then think recursion
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(RecursiveFactorial(5));
        }

        public  static int RecursiveFactorial(int num)
        {
            if(num == 0)
            {
                return 1;
            }
            return num * RecursiveFactorial(num - 1);
        }



    }
}
