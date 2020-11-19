using System;

namespace Construct_the_String_1335B
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int  j= 0;  j< T; j++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                string alphabet = "abcdefghijklmnopqrstuvwxyz";
                int n = input[0];
                int a = input[1];
                int b = input[2];
                for (int i = 0; i < n; i++)
                {
                    Console.Write(alphabet[i % b]);
                }
                Console.WriteLine();
            }
        }
    }
}
