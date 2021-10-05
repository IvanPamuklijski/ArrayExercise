using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split();
            string[] arrTwo = Console.ReadLine().Split();

            foreach (string element in arrTwo)
            {
                for (int i = 0; i < arrOne.Length; i++)
                {
                    string seccondArr = arrOne[i];
                    if (element == seccondArr)
                    {
                        Console.Write(element + " ");
                        break;
                    }

                }
            }
            
        }
    }
}
