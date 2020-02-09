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

            // 文字列の入力
            string s = Console.ReadLine();

            string result = "";

            for(int i = 0; i < s.Length; i++)
            {
                result += "x";
            }

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
