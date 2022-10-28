public class MinimumSumOfFourDigitNumberAfterSplittingDigits
{
    public int MinimumSum(int num)
    {
        string number = num.ToString();
        char[] charNum = new char[number.Length];
        for(int i = 0; i < number.Length; i++)
        {
            charNum[i] = number[i];
        }

        return ((charNum[0] - '0') * 10 + charNum[2] - '0' + ((charNum[1] - '0') * 10 + charNum[3] - '0'));
    }
}


