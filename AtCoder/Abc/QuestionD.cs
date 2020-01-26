using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionD
    {
        public static void Main(string[] args)
        {
            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(Count(n));

            Console.Out.Flush();
        }

        public static long Count(long n)
        {
            if (n == 1)
            {
                return 1;
            }

            return 1 + 2 * Count(n / 2);
        }
    }
}
