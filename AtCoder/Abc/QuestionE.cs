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
            var inputIntArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i));
            int n = inputIntArray.ElementAt(0);
            int m = inputIntArray.ElementAt(1);

            //宝箱の状態とその最安値
            Dictionary<int, int> boxes = new Dictionary<int, int>();

            //鍵とその価格
            List<int> prices = new List<int>();
            //鍵と開けられる宝箱
            List<List<int>> effects = new List<List<int>>();

            bool[] flags = new bool[n];

            for(int i = 0; i < m; i++)
            {
                var ab = Console.ReadLine().Split(' ').Select(j => int.Parse(j));
                prices.Add(ab.ElementAt(0));
                var cms = Console.ReadLine().Split(' ').Select(j => int.Parse(j) - 1).ToList(); //宝箱の番号を0開始にする
                effects.Add(cms);

                int key = 0;
                foreach(int box in cms)
                {
                    flags[box] = true;
                    key += (int)Math.Pow(2, (box + 1));
                }

                if(boxes.ContainsKey(key) == false || boxes[key] > ab.ElementAt(0))
                {

                }
            }

            //開けられない箱があれば終了
            if(flags.Contains(false))
            {
                Console.WriteLine(-1);
                return;
            }



        }
    }
}
