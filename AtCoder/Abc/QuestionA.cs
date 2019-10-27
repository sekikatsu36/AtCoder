using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abc143/tasks/abc143_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            var inputIntArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i));

            int a = inputIntArray.ElementAt(0);
            int b = inputIntArray.ElementAt(1);

            var result = a - (2 * b);
            result = result < 0 ? 0 : result;

            Console.WriteLine(result);
        }
    }
}
