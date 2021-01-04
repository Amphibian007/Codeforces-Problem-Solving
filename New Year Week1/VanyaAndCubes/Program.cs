using System;

namespace VanyaAndCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,sum = 0;
            int input = int.Parse(Console.ReadLine());
            for( n = 1; n <= 10000; n++)
            {
                sum += (n * (n + 1)) / 2;
                if (sum > input)
                    break;
            }
            Console.WriteLine(n-1);
        }
    }
}
