using AtCoder.Abc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Exec(args);
                Console.WriteLine("============ Retry ============");
            }
        }

        private static void Exec(string[] args)
        {
            //QuestionA.Main(args);
            //QuestionB.Main(args);
            QuestionC.Main(args);
            //QuestionD.Main(args);
            //QuestionE.Main(args);
            //QuestionF.Main(args);
        }

        public void Input()
        {
            // 文字列の入力
            string s = Console.ReadLine();

            // 整数の入力
            int n = int.Parse(Console.ReadLine());
            long nl = long.Parse(Console.ReadLine());

            // 文字列配列の入力
            string[] inputStrArray = Console.ReadLine().Split(' ');

            // 整数配列の入力
            var inputIntArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i));
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i));
        }

        public void Output()
        {
            Console.WriteLine("hoge");
        }
    }
}
