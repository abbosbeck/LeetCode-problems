public static class SelfDividingNumberss
{
    public static IList<int> SelfDividingNumbers(int left, int right)
    {
        List<int> result = new List<int>();
        for(int i = left; i <= right; i++)
        {
            if(Checker(i))
            {
                result.Add(i);
            }
        }
        return result;
    }
    public static bool Checker(int a)
    {
        int asl = a;
        int last = a;
        while(a > 0)
        {
            last = a % 10;
            if (last == 0 || asl % last != 0)
                return false;
            a /= 10;

        }
        return true;
    }
}