using System;
using System.Linq;


namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int ines = int.Parse(Console.ReadLine());
            int[] evenArr = new int[ines];
            int[] oddArr = new int[ines];
            for (int i = 0; i < ines; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    evenArr[i] = numbers[0];
                    oddArr[i] = numbers[1];
                }
                else
                {
                    evenArr[i] = numbers[1];
                    oddArr[i] = numbers[0];
                }
            }
            Console.WriteLine(String.Join(" ", evenArr));
            Console.WriteLine(String.Join(" ", oddArr));
        }
    }
}
