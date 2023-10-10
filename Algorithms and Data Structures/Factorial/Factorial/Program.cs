using System;

namespace Factorial
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MainProcedure();
        }

        private static void MainProcedure()
        {
            try
            {
                var factorialCalculator = new FactorialCalculator();
                
                Console.Write("Please enter a number to calculate its factorial: ");
                
                var inputNumber = long.Parse(Console.ReadLine());
                
                if (inputNumber < 0)
                {
                    HandleException();
                }
                
                var factorial = factorialCalculator.CalculateFactorial(inputNumber);
                
                Console.WriteLine($"{inputNumber}! = {factorial}");
            }
            catch
            {
                HandleException();
            }
        }

        private static void HandleException()
        {
            Console.Clear();
            Console.WriteLine($"Invalid input! Please enter an integer number greater than or equal to 0.");
            MainProcedure();
            return;
        }
    }
}