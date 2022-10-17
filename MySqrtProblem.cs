public class MySqrtProblem
{
    public int MySqrt(int x)
    {
        if (x == 0)
            return 0;
        if (x == 1 || x == 2 || x == 3)
            return 1;
        if (x < 9)
            return 2;
        int start = 1, end = x / 2 + 1;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (mid == x / mid)
            {
                return mid;
            }
            else if (mid < x / mid)
            {
                start++;
            }
            else
                end = mid - 1;
        }
        return end;
    }
}