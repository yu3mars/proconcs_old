using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] h = new int[n + 2];
            int[] w = new int[n + 2];//hidarikara
            int[] e = new int[n + 2];//migikara
            bool[] checkw = new bool[n + 2];
            bool[] checke = new bool[n + 2];
            checkw[0] = true;
            checke[0] = true;
            checkw[n + 1] = true;
            checke[n + 1] = true;
            h[0] = int.MaxValue;
            h[n + 1] = int.MaxValue;
            Queue<int> qw = new Queue<int>();
            Queue<int> qe = new Queue<int>();
            for (int i = 1; i <= n; i++)
            {
                h[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= n; i++)
            {
                if (h[i] < h[i - 1])
                {
                    qw.Enqueue(i);
                    w[i] = 0;
                }
                if (h[i] < h[i + 1])
                {
                    qe.Enqueue(i);
                    e[i] = 0;
                }
            }
            while (qw.Count > 0)
            {
                int next = qw.Dequeue();
                
            }
            for (int i = 1; i <= n; i++)
            {
                
                if (checkw[i] == false && h[i] < h[i - 1])
                {
                    
                }
            }
            for (int i = n; i >= 1; i--)
            {
                for (int j = i - 1; j >=1; j--)
                {
                    if (h[i] >= h[j])
                    {
                        e[i] += 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            for (int i = 1; i <= n; i++)
            {
                int ans = w[i] + e[i];
                Console.WriteLine(ans);
            }
        }
    }
}

