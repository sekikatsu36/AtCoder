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
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <10; i++)
            {
                for (int j = i; j < 10; j++)
                {
                    if (i * j == n)
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }
            }

            Console.WriteLine("No");
        }
    }
}
