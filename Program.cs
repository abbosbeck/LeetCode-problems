public class Program
{
    public static void Main(string[] args)
    {
        foreach(var a in SelfDividingNumberss.SelfDividingNumbers(1, 22))
        {
            Console.WriteLine(a);
        };
    }
}
