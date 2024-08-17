using System;

namespace _03._Combinations
{
    internal class Program
    {
        private static int n;

        static void Main(string[] args)
        {
           int q = int.Parse(Console.ReadLine());
            for (int i = 0; i <= q; i++)
            {
                for (int b = 0; b <= q; b++)
                {
                    for (int c = 0; c <= q; c++)
                    {
                       if (i +b+c == q)
                        {
                            Console.WriteLine(i +b+c);
                        }

                    }
                }
            }

        }
    }
}
