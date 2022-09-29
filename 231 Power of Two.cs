using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masala
{
    public class _231_Power_of_Two
    {
        public static bool Checker(int n)
        {
            if (n == 1 || n == 2)
                return true;
            if (n % 8 != 0)
                return false;
            int num = 2;
            while (num <= n)
            {
                if (num == n)
                {
                    return true;
                }

                n /= 2;

            }
            return false;
        }

    }
}
