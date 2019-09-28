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
            var inputIntArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i));
            int n = inputIntArray.ElementAt(0);
            int k = inputIntArray.ElementAt(1);
            var hArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i));

            int result = 0;
            foreach(int h in hArray)
            {
                if(h >= k)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
