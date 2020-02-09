using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Lib
{
    public static class Calc
    {
        /// <summary>
        /// x / a以上の最大の整数を求める
        /// </summary>
        public static long Ceiling(long x, long a)
        {
            return Convert.ToInt32(Math.Ceiling((double)x / a));
        }

        /// <summary>
        /// nCrを求める
        /// </summary>
        public static long nCr(int n, int r)
        {
            // naive: return Factorial(n) / (Factorial(r) * Factorial(n - r));
            return nPr(n, r) / Factorial(r);
        }

        /// <summary>
        /// nPrを求める
        /// </summary>
        public static long nPr(int n, int r)
        {
            // naive: return Factorial(n) / Factorial(n - r);
            return FactorialDivision(n, n - r);
        }

        private static long FactorialDivision(int topFactorial, int divisorFactorial)
        {
            long result = 1;
            for (int i = topFactorial; i > divisorFactorial; i--)
                result *= i;
            return result;
        }

        private static long Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }
    }
}
