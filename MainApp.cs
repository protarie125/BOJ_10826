using System;
using System.Collections.Generic;
using System.Numerics;

namespace BOJ_10826
{
    internal static class MainApp
    {
        private static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var n = int.Parse(line);

            if (0 == n)
            {
                Console.WriteLine(0);
                return;
            }

            if (1 == n)
            {
                Console.WriteLine(1);
                return;
            }

            Memo = new List<BigInteger>(n + 1);
            for (int i = 0; i <= n; i++)
            {
                Memo.Add(-1);
            }
            Memo[0] = 0;
            Memo[1] = 1;

            Console.WriteLine(Fibo(n));
        }

        private static List<BigInteger> Memo { get; set; }

        private static BigInteger Fibo(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                if (Memo[i] < 0)
                {
                    Memo[i] = Memo[i - 1] + Memo[i - 2];
                }
            }

            return Memo[n];
        }
    }
}