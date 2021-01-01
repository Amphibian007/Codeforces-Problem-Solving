using System;

namespace Remove_Smallest
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                bool mark = true;
                int n = int.Parse(Console.ReadLine());
                int[] input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                Array.Sort(input);
                if (n == 1)
                    Console.WriteLine("YES");
                else
                {
                    for (int j = 0; j < n-1; j++)
                    {
                        if ((input[j + 1] - input[j]) > 1)
                            mark = false;
                    }
                    if (mark)
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");

                }
            }
        
        }
    }
}
