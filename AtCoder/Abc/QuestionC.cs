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
            // 整数の入力
            int n = int.Parse(Console.ReadLine());

            // 文字列の入力
            string s = Console.ReadLine();

            char current = '%';
            long result = 0;
            foreach(char c in s)
            {
                if(c == current)
                {
                    continue;
                }
                result++;
                current = c;
            }

            Console.WriteLine(result);
        }
    }
}
