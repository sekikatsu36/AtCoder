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
            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            // 整数配列の入力
            var hArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToList();

            hArray.Sort();

            long result = 0;
            for(int i = 0; i < hArray.Count - inputLongArray[1]; i++)
            {
                result += hArray[i];
            }

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
