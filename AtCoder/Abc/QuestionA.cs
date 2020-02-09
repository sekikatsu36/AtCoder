using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abc141/tasks/abc141_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列配列の入力
            string[] inputStrArray = Console.ReadLine().Split(' ');
            string s = inputStrArray[0];
            string t = inputStrArray[1];

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            long a = inputLongArray[0];
            long b = inputLongArray[1];

            // 文字列の入力
            string u = Console.ReadLine();

            if(s == u)
            {
                Console.WriteLine($"{a - 1} {b}");
            }
            else
            {
                Console.WriteLine($"{a} {b - 1}");
            }

            Console.Out.Flush();
        }
    }
}
