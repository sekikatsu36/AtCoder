using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionD
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            long n = inputLongArray[0];
            long k = inputLongArray[1];

            // 整数配列の入力
            var aArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();


            string result = "";

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public static void Test(long k, long[] aArray)
        {
            if(aArray.Length <= 2)
            {

            }

            long index = aArray.Length / 2;

            //if(aArray[index] * aArray[index + 1] < )

            ////とりあえずaArrayを半分に切る
            //var fist = aArray.Take(aArray.Length / 2);
            //var second = 
        }
    }
}
