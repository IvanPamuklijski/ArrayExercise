
using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] people = new int[n];
            int totalPassenger = 0;
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                totalPassenger += people[i];

            }

            foreach (var item in people)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(totalPassenger);

        }
    }
}
