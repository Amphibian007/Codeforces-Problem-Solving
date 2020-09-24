using System;

namespace Hotilier_1200A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] rooms = new int[10];
            for(int i = 0; i < n; i++)
            {
                if (input[i] == 'L')
                    rooms[Array.IndexOf(rooms, 0)] = 1;
                else if (input[i] == 'R')
                    rooms[Array.LastIndexOf(rooms, 0)] = 1;
                else
                    rooms[int.Parse(input[i].ToString())]=0;
            }
            Console.WriteLine(string.Join("",rooms));
        }
    }
}
