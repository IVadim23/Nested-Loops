﻿using System;

namespace _02._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("  ...");
                for (int j = 1; j <= 10; j++)
                {
                    int p = i * j;
                    Console.WriteLine($"{i} * {j} = {p}");
                }
                   
            }
        }
    }
}
