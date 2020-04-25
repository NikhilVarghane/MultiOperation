namespace MultiOperations
{
    class Factorial
    {
        int factorial = 1;
        public int CalculateFactorial(int fn)
        {
            for (int i = fn; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
