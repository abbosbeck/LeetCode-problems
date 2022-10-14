using System.Collections;

public class Solution
{
    public int RomanToInt(string s)
    {
        Hashtable numbers = new Hashtable()
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };
        int result = 0;
        int length = s.Length;
        for (int i = 0; i < length; i++)
        {
            if (i != s.Length - 1 && ((s[i] == 'I' && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                || (s[i] == 'X' && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                || (s[i] == 'C') && (s[i + 1] == 'D' || s[i + 1] == 'M')))
            {
                result += Convert.ToInt32(numbers[s[i + 1]]);
                result -= Convert.ToInt32(numbers[s[i]]);
                i++;
            }
            else
                result += Convert.ToInt32(numbers[s[i]]);
        };
        return result;
    }
}