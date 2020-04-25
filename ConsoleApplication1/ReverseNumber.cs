namespace MultiOperations
{
    class ReverseNumber
    {
        int rev = 0, m;
        public int CalculateReverseNumber(int n)
        {
            while(n>0)
            {
                m = n % 10;
                rev = (rev * 10) + m;
                n = n / 10;
            }
            return rev;
        }
    }
}
