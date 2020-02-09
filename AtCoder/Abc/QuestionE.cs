using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionE
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            string n = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            int first = int.Parse(n.Substring(0,1));

            long result = 0;

            if (n.Length < k)
            {
                result = 0;
            }
            else
            {
                result = Test(n, k);
            }

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public static long Test(string n, int k)
        {
            if(n.Length == 0)
            {
                return 0;
            }
            int first = int.Parse(n.Substring(0, 1));
            if (n.StartsWith("0"))
            {
                //0始まりは、無視する
                return Test(n.Substring(1), k);
            }
            if (n.Length < k)
            {
                return 0;
            }

            long result = 0;

            if (k == 1)
            {
                //最上位以外は1～9の9個が該当する
                //最上位だけ、1～{first-1}個が該当
                result = 9 * (n.Length - 1);
                result += first;
            }
            else
            {
                //sの最大桁数を使わない場合
                //残りのs.Length - 1からk箇所とって、k^10 -1をかければいい

                result = nCr(n.Length - 1, k) * (long)(Math.Pow(9, k));

                //sの最大桁数を使う場合

                //最大桁数が最大値でないなら、残りのs.Length -1 からk-1箇所取って、(k-1)^10-1をかければいい
                result += (first - 1) * nCr(n.Length - 1, k-1) * (long)(Math.Pow(9, k-1));

                //最大桁数が最大値の場合、再起で求める
                result += Test(n.Substring(1), k - 1);
            }

            //Program.Debug.Log($"Test({n},{k}) -> {result}");
            return result;
        }


        public static long nCr(int n, int r)
        {
            // naive: return Factorial(n) / (Factorial(r) * Factorial(n - r));
            return nPr(n, r) / Factorial(r);
        }

        public static long nPr(int n, int r)
        {
            // naive: return Factorial(n) / Factorial(n - r);
            return FactorialDivision(n, n - r);
        }

        private static long FactorialDivision(int topFactorial, int divisorFactorial)
        {
            long result = 1;
            for (int i = topFactorial; i > divisorFactorial; i--)
                result *= i;
            return result;
        }

        private static long Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }
    }
}
