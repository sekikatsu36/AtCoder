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

            long count = 0;

            Dictionary<string, long> dic = new Dictionary<string, long>();
            for (int i = 0; i < n; i++)
            {
                // 文字列の入力
                string s = Console.ReadLine();

                if (dic.ContainsKey(s))
                {
                    dic[s]++;
                }
                else
                {
                    dic.Add(s, 1);
                }

                if (dic[s] > count)
                {
                    count = dic[s];
                }
            }

            List<string> results = new List<string>();
            foreach (var kv in dic)
            {
                if (kv.Value == count)
                {
                    results.Add(kv.Key);
                }
            }

            results.Sort(StringComparer.OrdinalIgnoreCase);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            Console.Out.Flush();
        }
    }
}
