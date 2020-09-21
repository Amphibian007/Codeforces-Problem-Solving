using System;

namespace Reward_448A
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Cups = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] Medals = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var n = int.Parse(Console.ReadLine());
            var sumOfCups = 0;
            var sumOfMedals = 0;
            for (int i = 0; i < Cups.Length; i++)
                sumOfCups += Cups[i];
            for (int i = 0; i < Medals.Length; i++)
                sumOfMedals += Medals[i];         
            var numOfShlevesForCup = (sumOfCups + 5 - 1) / 5;
            var numOfShelvesForMedals = (sumOfMedals + 10 - 1) / 10;
            var total = numOfShlevesForCup + numOfShelvesForMedals;
            if(total>n)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");



        }
    }
}
