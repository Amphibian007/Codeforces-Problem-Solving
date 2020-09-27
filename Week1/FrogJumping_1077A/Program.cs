using System;

namespace FrogJumping_1077A
{
    class Program
    {
        static void Main(string[] args)
        {
            var T = int.Parse(Console.ReadLine());
            for (var i = 0; i < T; i++)
            {
                long[] input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
                var a = input[0];
                var b = input[1];
                var c = input[2];
                var step = c / 2;
                if (c % 2 == 1)
                    Console.WriteLine((a * (step + 1)) - b * step);
                else
                    Console.WriteLine(a * step - b * step);
            }

        }
    }
}
