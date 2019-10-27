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
            // 整数の入力
            int n = int.Parse(Console.ReadLine());

            var lArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToList();

            //配列をユニークにする
            Dictionary<long, long> dic = new Dictionary<long, long>();
            foreach (var l in lArray)
            {
                if (dic.ContainsKey(l))
                {
                    dic[l]++;
                }
                else
                {
                    dic.Add(l, 1);
                }
            }

            var keyArray = dic.Keys.ToList();
            keyArray.Sort();

            long result = 0;

            for(int i = 0; i < keyArray.Count; i++)
            {
                long aLength = keyArray[i];
                long aCount = dic[aLength];

                //その長さの棒だけで三角形を作れるか
                if (aCount > 2)
                {
                    result += (aCount * (aCount - 1) * (aCount - 2) / 6);
                }

                for(int j = i + 1; j < keyArray.Count; j++)
                {
                    long bLength = keyArray[j];
                    long bCount = dic[bLength];

                    //aとbだけで三角形を作れるか
                    if(aCount > 2 && bLength < (2 * aLength))
                    {
                        result += bCount * (aCount * (aCount - 1) / 2);
                    }
                    if(bCount > 2 && aLength < (2 * bLength))
                    {
                        result += aCount * (bCount * (bCount - 1) / 2);
                    }

                    for (int k = j + 1; k < keyArray.Count; k++)
                    {
                        long cLength = keyArray[k];
                        long cCount = dic[cLength];

                        //aとbとcで三角形を作れるか
                        if(cLength < aLength + bLength)
                        {
                            result += aCount * bCount * cCount;
                        }
                    }
                }
            }

            Console.WriteLine(result);

        }
    }
}
