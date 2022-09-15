using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masala
{
    public class NextPrimeNumber
    {
        public static void NextPrNumber(string[] args)
        {
            int a = 15;
            while(!ToqSon(a))
            {
                a++;
            }
            Console.WriteLine(a);
        }


        static bool ToqSon(int a)
        {
            bool check = true;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                    check = false;
            }

            return check;
    }
}
}
