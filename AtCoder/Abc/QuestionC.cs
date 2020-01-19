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
            var pArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            long min = long.MaxValue;
            long result = 0;
            for(int i = 0; i < n; i++)
            {
                if(pArray[i] <= min)
                {
                    result++;
                    min = pArray[i];
                }
            }

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
