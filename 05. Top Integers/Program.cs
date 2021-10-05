using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNum = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arrayNum.Length; i++)
            {
                bool isCurrNumBigger = true;
                for (int j =  i + 1; j < arrayNum.Length; j++)
                {
                    if (arrayNum[i] <= arrayNum[j])
                    {
                        isCurrNumBigger = false;
                    }

                }
                if (isCurrNumBigger)
                {
                    Console.Write(arrayNum[i] + " ");
                }


            }
        }
    }
}
