using System;

namespace FundamentalsI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fundamentals I");

            Console.WriteLine("Printing 1 through 255");
            for(var i = 1; i <256; i++)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("Printing 1 through 100 divisible by 3 or 5, but not both");

            for(var i = 1; i < 101; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    continue;
                }
                else if(i %3 == 0)
                {
                    Console.WriteLine(i);
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("FizzBuzz");
            var x = 1;
            while( x < 101)
            {
                if(x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(x %3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                x ++;
            }
        }
    }
}
