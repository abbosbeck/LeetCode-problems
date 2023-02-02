public class SolutionIsPalindrome
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        int firstNumber = x;
        int newNumber = 0;
        while (x > 0)
        {
            newNumber = newNumber * 10 + (x % 10);
            x /= 10;
        }
        return firstNumber == newNumber;
    }
}