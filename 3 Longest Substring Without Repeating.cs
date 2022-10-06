public class Leng
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s != null)
        {
            int longestLength = 0;

            string curr = "";
            for (int i = 0; i < s.Length; i++)
            {
                curr = s[i].ToString();
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (!curr.Contains(s[j]))
                    {
                        curr = curr + s[j].ToString();
                    }
                    else
                    {
                        break;
                    }
                }
                if (curr.Length > longestLength)
                    longestLength = curr.Length;

            }
            if (curr.Length > longestLength)
                longestLength = curr.Length;

            return longestLength;
        }
        return 0;
    }
}


//Console.WriteLine(_231_Power_of_Two.Checker(16));
//Console.WriteLine(Fib.Fibon(5));
