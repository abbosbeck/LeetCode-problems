public class SumOfTwoElements
{
    public int MaxProduct(int[] nums)
    {
        int max = Max(nums);
        int secMax = SecondMax(nums, max);
        return (max-1)*(secMax - 1);

    }
    public int Max(int[] nums)
    {
        int max = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max)
                max = nums[i];
        }
        return max;
    }
    public int SecondMax(int[] nums, int max)
    {
        for(int i = 0; i < nums.Length; i++)
        {
            if(max == nums[i])
            {
                nums[i] = 0;
                i = nums.Length + 1;
            }
        }
        return Max(nums);
    }
}
