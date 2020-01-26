using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionE
    {
        private static Dictionary<long, long> memoDic;
        private static List<Magic> magicList = new List<Magic>();

        public static void Main(string[] args)
        {
            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            long resultH = inputLongArray[0];
            long n = inputLongArray[1];

            magicList = new List<Magic>();
            memoDic = new Dictionary<long, long>();

            for (int i = 0; i < n; i++)
            {
                var magicArray = Console.ReadLine().Split(' ').Select(j => long.Parse(j)).ToArray();
                magicList.Add(new Magic(magicArray[0], magicArray[1]));
            }


            Console.WriteLine(dp(resultH));

            Console.Out.Flush();
        }
    
        private static long dp(long n)
        {
            if(memoDic.ContainsKey(n))
            {
                return memoDic[n];
            }
            if(n <= 0)
            {
                return 0;
            }

            long min = long.MaxValue;
            foreach(var magic in magicList)
            {
                if(magic.b > min)
                {
                    continue;
                }
                var cost = magic.b + dp(n - magic.a);
                if(cost < min)
                {
                    min = cost;
                }
            }
            memoDic.Add(n, min);
            return min;
        }
    }

    public class Magic : IComparable
    {
        public long a { get; set; }
        public long b { get; set; }
        public double e { get; set; }

        public Magic(long a, long b)
        {
            this.a = a;
            this.b = b;
            this.e = ((double)a) / b;
        }

        public int CompareTo(object obj)
        {
            return (int)((obj as Magic).e - e);
        }
    }
}