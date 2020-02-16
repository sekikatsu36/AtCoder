using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abc155/tasks/abc155_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            long a = inputLongArray[0];
            long b = inputLongArray[1];
            long c = inputLongArray[2];

            if(a == b)
            {
                if(b == c)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    Console.WriteLine("Yes");
                }
            }
            else
            {
                if(b == c && a != c)
                {
                    Console.WriteLine("Yes");
                }
                else if (b != c && a == c)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }

            Console.Out.Flush();
        }
    }
}
