using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2332
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mp = new int[n];
            int[] dp = new int[n];
            for (int i = 0; i < n; i++)
            {
                mp[i] = int.Parse(Console.ReadLine());
                dp[i] = int.MaxValue;
            }
            dp[0] = 0;
            Queue<int> q = new Queue<int>();
            q.Enqueue(0);
            while (q.Count > 0)
            {
                int now = q.Dequeue();
                if (mp[now] == 0)
                {
                    for (int i = 1; i <= 6; i++)
                    {
                        int next = now + i;
                        if (next > n - 1)
                        {
                            next = n - 1;
                            dp[next] = Math.Min(dp[next], dp[now] + 1);
                        }
                        else if (dp[next] >dp[now])
                        {
                            q.Enqueue(next);
                            dp[next] = Math.Min(dp[next], dp[now] + 1);
                        }
                    }
                }
                else
                {
                    int next = now + mp[now];
                    if (next > n - 1)
                    {
                        next = n - 1;
                    }
                    q.Enqueue(next);
                    dp[next] = Math.Min(dp[next], dp[now]);
                }                
            }
            Console.WriteLine(dp[n - 1]);
        }
    }
}
