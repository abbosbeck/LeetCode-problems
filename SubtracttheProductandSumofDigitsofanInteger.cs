public static class SubtracttheProductandSumofDigitsofanInteger
{
    public static int SubtractProductAndSum(int n)
    {
        int product = 1;
        int sum = 0;
        int i = 10;
        do
        {
            sum += n % 10;
            product *= n % 10;
            n /= 10;
        } while (i <= n || i - 10 < n);
        return product - sum;
    }
}