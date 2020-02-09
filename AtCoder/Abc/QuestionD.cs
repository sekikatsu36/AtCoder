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

            // 整数配列の入力(期待値*10に変換してしまう)
            var pArray = Console.ReadLine().Split(' ').Select(i => (long.Parse(i) + 1) * 5).ToArray();

            //とりあえず、1からK番目までの合計を出す
            long max = 0;
            for(long i = 0; i < k; i++)
            {
                max += pArray[i];
            }
            long current = max;
            //Program.Debug.Log($"{k-1} -> {max}");

            //最小を探す
            for (long i = k; i < n; i++)
            {
                long tmp = current + pArray[i] - pArray[i - k];
                //Program.Debug.Log($"{i}: {current} + {pArray[i]} - {pArray[i - k]} -> {tmp}");
                current = tmp;
                if(current > max)
                {
                    max = current;
                }
            }

            Console.WriteLine(max / 10f);

            Console.Out.Flush();
        }
    }
}
