using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abc144/tasks/abc144_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            var inputIntArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i));
            int a = inputIntArray.ElementAt(0);
            int b = inputIntArray.ElementAt(1);

            if(a < 10 && b < 10)
            {
                Console.WriteLine(a * b);
            }
            else
            {
                Console.WriteLine(-1);
            }

        }
    }
}
