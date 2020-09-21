using System;
using System.Linq;

namespace DistictDigits_1228A
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for (var i = input[0]; i <= input[1]; i++)
            {
                if (i.ToString().Length == i.ToString().Distinct().ToArray().Length)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(-1);
        }
    }
}
