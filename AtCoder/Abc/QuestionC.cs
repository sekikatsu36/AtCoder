using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionC
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            
            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            // 整数配列の入力
            var aArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            HashSet<long> set = new HashSet<long>();

            for(int i = 0; i < n; i++)
            {
                long a = aArray[i];
                if (set.Contains(a))
                {
                    Console.WriteLine("NO");
                    Console.Out.Flush();
                    return;
                }
                set.Add(a);
            }

            Console.WriteLine("YES");

            Console.Out.Flush();
        }
    }
}
