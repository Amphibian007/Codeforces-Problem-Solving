using System;

namespace New_Year_and_the_Christmas_Ornament_1091A
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var a = input[0];
            var b = input[1];
            var c = input[2];
            var result1 = Math.Min(Math.Min(a + 1, b), c - 1);
            Console.WriteLine(result1*3);
        }
    }
}
