public static class XOROperationinanArray
{
    public static int XorOperation(int n, int start)
    {
        int result = start;
        start += 2;
        for (int i = 1; i < n; i++)
        {
            result ^= start;
            start += 2;
        }
        return result;
    }
}
