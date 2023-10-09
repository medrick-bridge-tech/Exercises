using System;

namespace ConsoleApplication4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            bool isStarted = false;
            for (int i = maxNumber; i > 0; i--)
            {
                for (int d = 1; d < 4 * maxNumber - 1; d++)
                {
                    if (!isStarted)
                    {
                        isStarted = true;
                        Console.Write("**");
                    }
                    Console.Write("*");
                }

                for (int iIndex = 0; iIndex < maxNumber * 4; iIndex++)
                {
                    for (int jIndex = 0; jIndex < maxNumber * 4; jIndex++)
                    {
                        if (iIndex == jIndex || iIndex == (maxNumber * 4) - jIndex)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                        if (iIndex > maxNumber * 4 / 2)
                            break;
                    }
                    Console.WriteLine();
                }
                maxNumber--;
                isStarted = false;
            }
        }
    }
}