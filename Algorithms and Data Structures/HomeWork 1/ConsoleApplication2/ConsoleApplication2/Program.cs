using System;
namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int _num = random.Next(1,1000);
            Kolatz(_num);
        }

        private static bool PrimNum(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool SumPrime(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (PrimNum(sum))
                return true;
            else
                return false;
        }
        static void Kolatz(int num)
        {
            while (num != 1)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                    if (SumPrime(num))
                    {
                        Console.WriteLine(num + " Y ");
                    }
                    else
                    {
                        Console.WriteLine(num + " N ");
                    }
                }
                else
                {
                    num++;
                    if (SumPrime(num))
                    {
                        Console.WriteLine(num + " Y ");
                    }
                    else
                    {
                        Console.WriteLine(num + " N ");
                    }                
                }
            }
        }
    }
}