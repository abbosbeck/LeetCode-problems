using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masala
{
    public class Fib
    {
        public static int Fib(int n)
        {
            if (n < 3)
            {
                return n;
            }
            int a = 1;
            int b = 2;
            for (int i = 2; i < n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }

    }
}
