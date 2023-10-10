namespace Factorial
{
    public class FactorialCalculator
    {
        public long CalculateFactorial(long number)
        {
            if (number == 0)
            {
                return 1;
            }

            long factorial = number * CalculateFactorial(number - 1);
            
            return factorial;
        }
    }
}