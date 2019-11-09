using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionD
    {
        static List<Rect> goals;

        public static void Main(string[] args)
        {
            // 整数配列の入力
            var inputIntArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i));
            int n = inputIntArray.ElementAt(0);
            int m = inputIntArray.ElementAt(1);

            List<Rect> rect = new List<Rect>();

            List<Rect> starts = new List<Rect>();
            goals = new List<Rect>();

            for (int i = 0; i < m; i++)
            {
                var next = new Rect(Console.ReadLine());

                foreach(var neigbor in rect)
                {
                    if (next.L <= neigbor.R && next.R >= neigbor.L)
                    {
                        next.Neighbors.Add(neigbor);
                        neigbor.Neighbors.Add(next);
                    }
                }

                if(next.L == 1)
                {
                    starts.Add(next);
                }
                else if(next.R == n)
                {
                    goals.Add(next);
                }
                rect.Add(next);
            }

            foreach(var start in starts)
            {
                start.minDist = start.C;

                Recursive(start);
            }

            long result = long.MaxValue;
            foreach(var goals in goals)
            {
                result = Math.Min(result, goals.minDist);
            }
            if(result == long.MaxValue)
            {
                result = -1;
            }

            Console.WriteLine(result);
        }

        public static void Recursive(Rect target)
        {
            foreach(var next in target.Neighbors)
            {
                long dist = target.minDist + next.C;
                if(next.minDist > dist)
                {
                    next.minDist = dist;

                    Recursive(next);
                }
            }
        }

        public class Rect
        {
            public int L { get; set; }
            public int R { get; set; }
            public long C { get; set; }

            public long minDist { get; set; }

            public List<Rect> Neighbors { get; set; }

            public Rect(string input)
            {
                var inputIntArray = input.Split(' ').Select(i => int.Parse(i));
                L = inputIntArray.ElementAt(0);
                R = inputIntArray.ElementAt(1);
                C = inputIntArray.ElementAt(2);
                minDist = long.MaxValue;
                Neighbors = new List<Rect>();
            }

            public void SetDist(long dist)
            {
                if(this.minDist > dist)
                {
                    this.minDist = dist;
                }
            }
        }
    }
}
