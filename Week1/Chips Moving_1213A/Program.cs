using System;

namespace Chips_Moving_1213A
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var even = 0;
            var odd = 0;
            for(int i = 0; i < n; i++)
            {
                if (input[i] % 2 == 0)
                    even++;
                else
                    odd++;
            }
            Console.WriteLine(Math.Min(even,odd));
        }
    }
}
