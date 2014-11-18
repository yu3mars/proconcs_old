using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1186
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] xs = new int[11175];
            int[] ys = new int[11175];
            int cnt = 0;
            for (int i = 1; i <= 150; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    xs[cnt] = j;
                    ys[cnt] = i;
                    cnt += 1;
                }
            }
            var xys = xs.Zip(ys, (x, y) => new { x, y })
                .OrderBy(p => p.x * p.x + p.y * p.y)
                .ThenBy(p => p.x)
                .ToArray();
            for (; ; )
            {
                string[] str = Console.ReadLine().Split(' ');
                string a = str[0];
                string b = str[1];
                if (a == "0" && b == "0")
                {
                    return;
                }
                string str2 = "{ x = " + a + ", y = " + b + " }";
                for (int i = 0; i < xys.Length; i++)
                {
                    if (xys[i].ToString() == str2)
                    {
                        string[] target = xys[i + 1].ToString().Split(' ',',');
                        Console.WriteLine("{0} {1}", target[3], target[7]);
                        break;
                    }

                }
            }
        }
    }
}
