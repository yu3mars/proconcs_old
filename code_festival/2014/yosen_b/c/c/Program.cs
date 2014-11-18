using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] a = Console.ReadLine().ToCharArray();
            char[] b = Console.ReadLine().ToCharArray();
            char[] c = Console.ReadLine().ToCharArray();
            SortedList<char, int> al = new SortedList<char, int>();
            SortedList<char, int> bl = new SortedList<char, int>();
            SortedList<char, int> cl = new SortedList<char, int>();
            int n = a.Length / 2;
            foreach (char s in a)
            {
                if (al.ContainsKey(s))
                {
                    al[s] += 1;
                }
                else
                {
                    al.Add(s, 1);
                }
            }
            foreach (char s in b)
            {
                if (bl.ContainsKey(s))
                {
                    bl[s] += 1;
                }
                else
                {
                    bl.Add(s, 1);
                }
            }
            foreach (char s in c)
            {
                if (cl.ContainsKey(s))
                {
                    cl[s] += 1;
                }
                else
                {
                    cl.Add(s, 1);
                }
                if (al.ContainsKey(s) == false)
                {
                    al.Add(s, 0);
                }
                if (bl.ContainsKey(s) == false)
                {
                    bl.Add(s, 0);
                }
                if (al[s] + bl[s] < cl[s])
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            int aneed = 0;
            int bneed = 0;
            int either = 0;
            foreach (char s in cl.Keys)
            {
                if (al[s] <= cl[s])
                {
                    bneed += cl[s] - al[s];
                    either += al[s];
                }
                else if (bl[s] <= cl[s])
                {
                    aneed += cl[s] - bl[s];
                    either += bl[s];
                }
                else
                {
                    either += cl[s];
                }
            }
            if (aneed <= n && bneed <= n)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
