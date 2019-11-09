using System;
using System.Collections.Generic;
using System.Linq;

namespace AtCoder.Abc
{
    internal class QuestionB
    {
        public static void Main(string[] args)
        {
            // 整数の入力
            int n = int.Parse(Console.ReadLine());

            // 整数配列の入力
            var dArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i));

            if (dArray.ElementAt(0) != 0)
            {
                Console.WriteLine(0);
                return;
            }

            Dictionary<int, int> dic = new Dictionary<int, int>();

            int max = -1;
            foreach (var d in dArray)
            {
                if (dic.ContainsKey(d))
                {
                    dic[d]++;
                }
                else
                {
                    dic.Add(d, 1);
                }
                if (max < d)
                {
                    max = d;
                }
            }

            if (dic[0] != 1)
            {
                Console.WriteLine(0);
                return;
            }

            long result = 1;

            for (int i = 1; i <= max; i++)
            {
                if (dic.ContainsKey(i) == false)
                {
                    Console.WriteLine(0);
                    return;
                }

                for(int j = 0; j < dic[i]; j++)
                {
                    result *= dic[i - 1];
                    if (result >= 998244353)
                    {
                        result %= 998244353;
                    }
                }
            }

            Console.WriteLine(result %= 998244353);
        }
    }
}
