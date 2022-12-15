public static class SortArrayByParityClass
{
    public static int[] SortArrayByParity(int[] nums)
    {
        var res = new int[nums.Length];
        var even = 0;
        var odd = nums.Length - 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                res[even] = nums[i];
                even++;
            }
            else
            {
                res[odd] = nums[i];
                odd--;
            }
        }

        return res;
    }
}