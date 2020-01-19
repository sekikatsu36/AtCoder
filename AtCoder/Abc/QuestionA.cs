using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abc141/tasks/abc152_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);


            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            long n = inputLongArray[0];
            long m = inputLongArray[1];

            string result = n == m ? "Yes" : "No";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
