using System;
using System.Collections.Generic;
using System.Text;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abc142/tasks/abc142_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n % 2 == 0)
            {
                Console.WriteLine(0.5);
            }
            else
            {
                float count = (n / 2) + 1;
                Console.WriteLine(count / n);
            }
        }
    }
}
