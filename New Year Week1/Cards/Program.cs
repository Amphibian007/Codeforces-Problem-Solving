using System;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            int zero=0;
            int one = 0;
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'z')
                    zero++;
                if (input[i] == 'n')
                    one++;
            }
            for (int i = 0; i < one; i++)
            {
                Console.Write("1 ");
            }
            for (int i = 0; i < zero; i++)
            {
                Console.Write("0 ");
            }
           

        }
    }
}
