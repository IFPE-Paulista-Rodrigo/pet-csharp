﻿using System;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            var xs = new[] { 4, 7, 9 };
            var limits = FindMinMax(xs);
            Console.WriteLine($"Limits of [{string.Join(" ", xs)}] are {limits.min} and {limits.max}");
            // Saída:
            // Limits of [4 7 9] are 4 and 9

            var ys = new[] { -9, 0, 67, 100 };
            var (minimum, maximum) = FindMinMax(ys);
            Console.WriteLine($"Limits of [{string.Join(" ", ys)}] are {minimum} and {maximum}");
            // Saída:
            // Limits of [-9 0 67 100] are -9 and 100

            (int min, int max) FindMinMax(int[] input)
            {
                if (input is null || input.Length == 0)
                {
                    throw new ArgumentException("Cannot find minimum and maximum of a null or empty array.");
                }

                var min = int.MaxValue;
                var max = int.MinValue;
                foreach (var i in input)
                {
                    if (i < min)
                    {
                        min = i;
                    }
                    if (i > max)
                    {
                        max = i;
                    }
                }
                return (min, max);
            }
        }
    }
}
