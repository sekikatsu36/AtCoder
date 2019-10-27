using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionC
    {
        static List<long> primes;

        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            long result = long.MaxValue;
            for (long i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    var temp = (n / i) + i;
                    if (result > temp)
                    {
                        result = temp;
                    }
                }
            }

            Console.WriteLine(result - 2);
        }
    }
}
