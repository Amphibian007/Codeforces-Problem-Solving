using System;

namespace Fafa_and_his_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int team = 0;
            
                for(int i = 2; i <= input; i++)
                {
                    if ((input - i) % i == 0)
                        team++;                  
                }
            Console.WriteLine(team);

        }
    }
}
