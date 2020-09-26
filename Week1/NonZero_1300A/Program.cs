using System;

namespace NonZero_1300A
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int m = 0; m < T; m++)
            {
                var sum = 0;
                var count = 0;
                var n = int.Parse(Console.ReadLine());
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                for (int i = 0; i < n; i++)
                {
                    if (input[i] == 0)
                        count++;
                    sum += input[i];
                }

                if ((sum+count) == 0)
                    Console.WriteLine(count + 1);
                else
                    Console.WriteLine(count);

            }
        }
    }
}
