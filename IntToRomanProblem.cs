using System.Collections;

public class IntToRomanProblem
{
    public string IntToRoman(int num)
    {
        //string number = num.ToString();
        string result = "";
        Hashtable I = new Hashtable() { { 1, "I" }, { 2, "II" }, { 3, "III" }, { 4, "IV" }, { 5, "V" }, { 6, "VI" }, { 7, "VII" }, { 8, "VIII" }, { 9, "IX"} };
        Hashtable X = new Hashtable() { { 1, "X" }, { 2, "XX" }, { 3, "XXX" }, { 4, "XL" }, { 5, "L" }, { 6, "LX" }, { 7, "LXX" }, { 8, "LXXX" }, { 9, "XC" } };
        Hashtable C = new Hashtable() { { 1, "C" }, { 2, "CC" }, { 3, "CCC" }, { 4, "CD" }, { 5, "D" }, { 6, "DC" }, { 7, "DCC" }, { 8, "DCCC" }, { 9, "CM" } };
        Hashtable M = new Hashtable() { { 1, "M" }, { 2, "MM" }, { 3, "MMM" } };

        //int birlik = num % 10;
        //int onlik = num / 10 % 10;
        //int yuzlik = num / 100 % 10;
        //int minglik = num / 1000 % 10;
        result += M[num / 1000 % 10];
        result += C[num / 100 % 10];
        result += X[num / 10 % 10];
        result += I[num % 10];
        return result;
    }
}