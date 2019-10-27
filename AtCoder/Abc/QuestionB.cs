using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionB
    {
        public static void Main(string[] args)
        {
            // 整数の入力
            int n = int.Parse(Console.ReadLine());
            var dArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToList();

            long result = 0;
            for(int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    result += dArray[i] * dArray[j];
                }
            }

            Console.WriteLine(result);
        }
    }
}
