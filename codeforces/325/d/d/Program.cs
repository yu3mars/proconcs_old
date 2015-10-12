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
            int zzzz = int.Parse(Console.ReadLine());
            for (int zzz = 0; zzz < zzzz; zzz++)
            {
                Calc();
            }
        }

        private static void Calc()
        {
            string[] nk = Console.ReadLine().Split(' ');
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);
            string[] mapstr = new string[3];
            for (int i = 0; i < 3; i++)
            {
                mapstr[i] = Console.ReadLine();
            }
            bool[,] map = new bool[3, n + 10];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < n + 10; j++)
                {
                    map[i, j] = true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mapstr[i][j] != '.' && mapstr[i][j] != 's')
                    {
                        map[i, j] = false;
                    }
                }
            }
            //bool[] nowable = new bool[3];
            bool[] oldable = new bool[3];
            for (int i = 0; i < 3; i++)
            {
                if (mapstr[i][0] == 's')
                {
                    oldable[i] = true;
                }
            }
            for (int j = 1; j < n + 2; j++)
            {
                bool[] nowable = new bool[3];
                for (int i = 0; i < 3; i++)
                {
                    if (map[i, j] == true && oldable[i] == true)
                    {
                        nowable[i] = true;
                    }
                }
                oldable = nowable;
                if (j % 3 == 1)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (map[i, j] == true)
                        {
                            if (i == 0 && oldable[1] == true) nowable[0] = true;
                            if (i == 1 && (oldable[0] == true || oldable[2] == true))
                                nowable[1] = true;
                            if (i == 2 && oldable[1] == true) nowable[2] = true;
                        }
                    }
                    oldable = nowable;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (oldable[i] == true)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }
            Console.WriteLine("NO");
        }
    }
}
