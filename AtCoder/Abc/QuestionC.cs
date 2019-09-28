using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionC
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var aArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            int[] results = new int[n];
            for(int i = 0; i < n; i++)
            {
                int a = aArray[i];
                results[a - 1] = i + 1;
            }

            Console.WriteLine(string.Join(" ", results));
        }
    }
}
