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
            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            // 整数配列の入力
            var aArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            long total = aArray.Sum();

            string result = total >= inputLongArray[0] ? "Yes" : "No";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
