using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2589
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string dir = Console.ReadLine();
                if (dir == "#")
                {
                    return;
                }

                int n = 0;
                int w = 0;
                for (int i = 0; i < dir.Length; i++)
                {
                    if (dir[i] == 'n')
                    {
                        n += 1;
                    }
                    else if (dir[i]=='w')
                    {
                        w += 1;
                    }
                }
                if (w==0)
                {
                    Console.WriteLine(0);
                    continue;
                }
                else if (n==0)
                {
                    Console.WriteLine(90);
                    continue;
                }
                int u = 1;
                int d = 2;
                for (int i = 1; i < n; i++)
                {
                    d *= 2;
                }
                for (int i = 1; i < w; i++)
                {
                    u += d;
                    d *= 2;
                }
                u *= 45;
                d /= 2;
                if (d == 1)
                {
                    Console.WriteLine(u);
                }
                else
                {
                    Console.WriteLine("{0}/{1}", u, d);
                }
            }
        }
    }
}
