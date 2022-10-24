using Masala;
using System.Collections;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        var easy = new Easy();
        int a = 457;
    }
}

public class Easy
{
    public int Maximum69Number(int num)
    {
        var stringmatn = new StringBuilder();
        stringmatn.Append(num.ToString());
        for(int i = 0; i < stringmatn.Length; i++)
        {
            if (stringmatn[i] == '9')
                continue;
            else
            {
                stringmatn[i] = '9';
                break;
            }
        }
        return int.Parse(stringmatn.ToString());
    }


    public class Problem
    {
        public int FindGCD(int[] nums)
        {
            Array.Sort(nums);
            return GreatCommonDivisor(nums[nums.Length - 1], nums[0]);
        }
        static int GreatCommonDivisor(int a, int b)
        {
            return a % b == 0 ? b : GreatCommonDivisor(b, a % b);
        }
    }
}