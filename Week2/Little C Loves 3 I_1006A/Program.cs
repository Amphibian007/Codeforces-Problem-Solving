using System;

namespace Little_C_Loves_3_I_1006A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if((n-2)%3==0)
                Console.WriteLine($"1 2 {n-3}");
            else
                Console.WriteLine($"1 1 {n-2}");
        }
    }
}
