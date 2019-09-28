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
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i));
            long a = inputLongArray.ElementAt(0);
            long b = inputLongArray.ElementAt(1);

            Dictionary<long, long> aDic = GenerateDic(a);
            Dictionary<long, long> bDic = GenerateDic(b);
            Dictionary<long, long> resultDic = new Dictionary<long, long>();

            foreach(long key in aDic.Keys)
            {
                if(bDic.ContainsKey(key))
                {
                    long count = Math.Min(aDic[key], bDic[key]);
                    resultDic.Add(key, count);
                }
            }

            Console.WriteLine(resultDic.Keys.Count + 1);
        }

        public static Dictionary<long, long> GenerateDic(long n)
        {
            Dictionary<long, long> dic = new Dictionary<long, long>();
            foreach (long i in PrimeFactors(n))
            {
                if (dic.ContainsKey(i))
                {
                    dic[i]++;
                }
                else
                {
                    dic.Add(i, 1);
                }
            }
            return dic;
        }

        public static IEnumerable<long> PrimeFactors(long n)
        {
            long i = 2;
            long tmp = n;

            while (i * i <= n) //※1
            {
                if (tmp % i == 0)
                {
                    tmp /= i;
                    yield return i;
                }
                else
                {
                    i++;
                }
            }
            if (tmp != 1) yield return tmp;//最後の素数も返す
        }
    }
}
