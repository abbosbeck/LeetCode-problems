public static class ArrayPartition
{
    public static int ArrayPairSum(int[] nums)
    {
        int sum = 0;
        Array.Sort(nums);
        for(int i = 0; i < nums.Length; i += 2)
        {
            sum += nums[i];
        }
        return sum; 
    }
}