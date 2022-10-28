public class MaximumWealthProblem
{
    public int MaximumWealth(int[][] accounts)
    {
        int sum = accounts[0].Sum();
        for(int i = 1; i < accounts.Length; i++)
        {
            if(accounts[i].Sum() > sum)
                sum = accounts[i].Sum();
        }
        return sum;
    }
}


