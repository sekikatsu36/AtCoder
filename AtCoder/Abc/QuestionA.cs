using System;
using System.Collections.Generic;
using System.Text;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abc141/tasks/abc141_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine((n / 2) - 1);
            }
            else
            {
                Console.WriteLine((n - 1) / 2);
            }
        }
    }
}
