using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionF
    {
        public static void Main(string[] args)
        {
            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            long d = inputLongArray[1];
            long a = inputLongArray[2];

            List<Enemy> enemies = new List<Enemy>();

            for(int i= 0; i < inputLongArray[0]; i++)
            {
                // 整数配列の入力
                enemies.Add(new Enemy(Console.ReadLine().Split(' ').Select(j => long.Parse(j)).ToArray()));
            }
            enemies.Sort();

            //使った爆弾のリスト
            List<long> bombQueue = new List<long>();
            long result = 0;
            int currentEnemyIndex = 0;
            Enemy currentEnemy = enemies[0];

            bool flag = true;
            while(flag)
            {
                if(bombQueue.Count == 0 || currentEnemy.x <= bombQueue[0])
                {
                    //爆弾の効果が切れる前に、新たな敵が見つかった
                    if(bombQueue.Count * a < currentEnemy.h)
                    {
                        //今の爆弾ではこの敵を倒せない
                        for (int i = bombQueue.Count; i < (int)(Math.Ceiling((double)currentEnemy.h / a)); i++)
                        {
                            bombQueue.Add(currentEnemy.x + 2 * d);
                            result++;
                        }
                    }
                    else
                    {
                        //この敵はすでに倒しているので無視
                    }

                    currentEnemyIndex++;
                    if(currentEnemyIndex == enemies.Count)
                    {
                        break;
                    }
                    currentEnemy = enemies[currentEnemyIndex];
                }
                else
                {
                    //爆弾の効果が切れる
                    bombQueue.RemoveAt(0);
                }
            }

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }

    public class Enemy : IComparable
    {
        public long x { get; set; }
        public long h { get; set; }

        public Enemy(long[] input)
        {
            this.x = input[0];
            this.h = input[1];
        }

        public int CompareTo(object obj)
        {
            //xの低い順にソートされる
            return (int)(x - (obj as Enemy).x);


            //hの高い順にソートされる
            //return (int)((obj as Enemy).h - h);
        }
    }
}
