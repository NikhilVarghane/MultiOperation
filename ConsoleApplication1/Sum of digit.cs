namespace MultiOperations
{
    class Sum_of_digit
    {
        int sum = 0, m;
        public int NumberOfDigit(int number)
        {
            while(number>0)
            {
                m = number % 10;
                sum = sum + m;
                number = number / 10;
            }
            return sum;
        }
    }
}
