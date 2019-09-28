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
            // 整数の入力
            int n = int.Parse(Console.ReadLine());
            // 文字列の入力
            string s = Console.ReadLine();

            bool[] enables = new bool[n+1]; //0は欠番

            int li = 1; //次に左から来た人が座る位置(＝まだ空いてる位置)
            int ri = n; //次に右から来た人が座る位置(＝まだ空いてる位置)
            bool flag = true;

            foreach(char c in s.ToArray())
            {
                if (flag && ri < li)
                {
                    //1週目が埋まり切ったので、2週目開始
                    flag = false;
                    li = 1;
                    ri = n;
                }

                if (c == 'L')
                {
                    if(flag)
                    {
                        Console.WriteLine(li);
                        enables[li] = true;
                        li += 2;
                    }
                    else
                    {
                        for(int i = li; i <= n; i++)
                        {
                            if(enables[i] == false)
                            {
                                Console.WriteLine(i);
                                enables[i] = true;
                                li = i;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    if (flag)
                    {
                        Console.WriteLine(ri);
                        enables[ri] = true;
                        ri -= 2;
                    }
                    else
                    {
                        for (int i = ri; i >= 0; i--)
                        {
                            if (enables[i] == false)
                            {
                                Console.WriteLine(i);
                                enables[i] = true;
                                ri = i;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
