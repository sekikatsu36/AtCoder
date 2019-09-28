using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtCoder.Abc
{
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            // 整数の入力
            int n = int.Parse(Console.ReadLine());

            // 整数配列の入力
            var aArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i));
            var sortedArray = aArray.OrderBy(a => a);

            long result = long.MaxValue;
            for(int i = 0; i < n; i++)
            {
                int tmp = sortedArray.ElementAt(i + n) - sortedArray.ElementAt(i);
                if(tmp < result)
                {
                    result = tmp;
                }
            }
            Console.WriteLine(result);
        }
    }
}
