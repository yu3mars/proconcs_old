using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0567
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            int baseprice = int.Parse(str[0]);
            int totalcal = int.Parse(Console.ReadLine());
            int toppingprice = int.Parse(str[1]);
            int ans = totalcal / baseprice;

            int[] toppings = new int[n];
            for (int i = 0; i < n; i++)
            {
                toppings[i] = int.Parse(Console.ReadLine());
            }
            int cnt = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < cnt-1; j++)
                {
                    if (toppings[j] < toppings[j + 1])
                    {
                        int tmp = toppings[j];
                        toppings[j] = toppings[j + 1];
                        toppings[j + 1] = tmp;
                    }
                }
                cnt -= 1;
            }
            for (int i = 0; i < n; i++)
            {
                int nextcal = toppings[i];
                totalcal += nextcal;
                int nextans = totalcal / (baseprice + toppingprice * (i+1));
                if (ans < nextans)
                {
                    ans = nextans;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
