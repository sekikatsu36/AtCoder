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

            long a = inputLongArray[0];
            long b = inputLongArray[1];

            long result = 0;
            long tmp = 1;
            if (a < b)
            {
                for (int i = 0; i < b; i++)
                {
                    result += tmp * a;
                    tmp *= 10;
                }
            }
            else
            {
                for (int i = 0; i < a; i++)
                {
                    result += tmp * b;
                    tmp *= 10;
                }
            }
            
            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
