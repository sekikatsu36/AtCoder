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
            var inputIntArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i));

            long a = inputIntArray.ElementAt(0);
            int b = inputIntArray.ElementAt(1);
            double x = inputIntArray.ElementAt(2);

            //水が入っていない体積を求める
            double max = a * a * b;
            double empty = max - x;

            if (x < max / 2)
            {
                //水の入っている領域が、xと一致すればいい
                double tan = (2 * x) / (b * b * a);
                var radian = Math.Atan(tan);
                var theta = radian * 180 / Math.PI;
                Console.WriteLine(90 - theta);
            }
            else
            {
                //この体積になるような角度を求める
                //これがa^3 * tan0 が一致すればいい
                double tan = (2 * empty) / (a * a * a);
                var radian = Math.Atan(tan);
                var result = radian * 180 / Math.PI;
                Console.WriteLine(result);
            }
        }
    }
}
