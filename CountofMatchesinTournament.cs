﻿public static class CountofMatchesinTournament
{
    public static int NumberOfMatches(int n)
    {
        int result = 0;
        while(n > 1)
        {
            if(n % 2 == 0)
            {
                result += n / 2;
                n /= 2;
            }
            else
            {
                result += n / 2;
                n = n / 2 + 1;

            }
        }
        return result;
    }
}