public static class AverageSalaryExcludingtheMinimumandMaximumSalary
{
    public static double Average(int[] salary)
    {
        double result = 0;
        Array.Sort(salary);
        for(int i = 1; i < salary.Length - 1; i++)
        {
            result += salary[i];
        }
        return result / (salary.Length - 2);
    }
}