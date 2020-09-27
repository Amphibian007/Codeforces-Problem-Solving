using System;

namespace Yet_Another_Two_Integers_Problem_1409A
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var a = input[0];
                var b = input[1];
                var minus = Math.Abs(a - b);

                if (minus == 0)
                    Console.WriteLine(0);
                else if (minus <= 10)
                    Console.WriteLine(1);
                else
                {
                    if (minus % 10 == 0)
                        Console.WriteLine(minus / 10);
                    else
                        Console.WriteLine((minus / 10) + 1);
                }
            }
        }
    }
}
