﻿using System;
using System.Linq;

namespace AdventOfCode_2019
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Advent of Code 2019");
            Console.WriteLine("===================");
            Console.WriteLine();

            Day_01.Puzzle.SolveWith(InputProvider.Day1Input);
            Day_02.Puzzle.SolveWith(InputProvider.Day2Input);
        }
    }
}
