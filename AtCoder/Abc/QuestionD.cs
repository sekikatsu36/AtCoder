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
            
            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            long result = 0;
            if(n < 10)
            {
                result = n;
            }
            else
            {
                for (long i = 0; i <= n; i++)
                {
                    result += Count(i);
                }
            }

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public static long Count(long n)
        {
            string str = n.ToString();
            if(str.EndsWith("0"))
            {
                return 0; //0で終わっている数は、解がゼロ
            }

            long result = 0;

            // 左側がn (a...z) の場合、右側は(z...a)になる

            if(str[0] == str[str.Length - 1])
            {
                //最初と最後が同じ場合、その数字1桁のものがOKになる
                result = 1;
            }
            for(int i = 2; i < str.Length; i++) //nと桁数と同じ場合、途中からnを超える場合があるので、別で計算
            {
                //i桁の場合を数える (10^桁数-2)
                result += (long)Math.Pow(10, i - 2);
            }

            //右側の個数は、10^桁数-2
            //ただし、nを超えてしまうとアウトなので、その検出
            long max = long.Parse(str[str.Length - 1].ToString().PadRight(str.Length - 1, '9') + str[0]); //最大の値
            long min = long.Parse(str[str.Length - 1].ToString().PadRight(str.Length - 1, '0') + str[0]); //最大の値
            if(n < min)
            {
            }
            else if(max <= n)
            {
                result += (long)Math.Pow(10, str.Length - 2);
            }
            else
            {
                long diff = long.Parse(str.Substring(1, str.Length - 2));
                result += diff + 1;
            }

            //左右入れ替えたパターンを含めるので、二倍にする
            result *= 2;

            //入れ替えられないパターンを除外
            if (str[0] == str[str.Length - 1])
            {
                result--;
            }

            Debug.Log(n + " : " + result);

            return result;
        }
    }
}
