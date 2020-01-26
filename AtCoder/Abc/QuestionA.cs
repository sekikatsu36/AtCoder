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
            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            long result = inputLongArray[0];
            long count = 0;
            while(result > 0)
            {
                result -= inputLongArray[1];
                count++;
            }
            Console.WriteLine(count);

            Console.Out.Flush();
        }
    }
}
