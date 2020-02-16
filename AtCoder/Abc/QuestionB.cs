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
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            // 整数配列の入力
            var aArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();


            string result = "APPROVED";
            foreach(long a in aArray)
            {
                if(a % 2 == 0)
                {
                    if(a % 3 !=0 && a % 5 != 0)
                    {
                        result = "DENIED";
                        break;
                    }
                }
            }

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
