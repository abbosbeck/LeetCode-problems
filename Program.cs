public class Program
{
    public static void Main(string[] args)
    {
        foreach(int a in SortArrayByParityClass.SortArrayByParity(new int[] { 6, 2, 6, 5, 1, 2 }))
        {
            Console.WriteLine(a);
        }
    }
}
