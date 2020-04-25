namespace MultiOperations
{
    class StringCountring
    {
        public int countstring(string str)
        {
            int count = 0;
            for(int i=0;i<str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
